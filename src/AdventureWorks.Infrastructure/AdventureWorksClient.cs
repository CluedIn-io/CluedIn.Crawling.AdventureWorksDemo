using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using CluedIn.Core;
using CluedIn.Core.Logging;
using CluedIn.Core.Providers;
using CluedIn.Crawling.AdventureWorks.Core;
using CluedIn.Crawling.AdventureWorks.Core.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CluedIn.Crawling.AdventureWorks.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class AdventureWorksClient
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger _log;
        private readonly AdventureWorksCrawlJobData _jobData;
        private readonly int _retryIntervalMs = 10000;

        public AdventureWorksClient(ILogger log, AdventureWorksCrawlJobData adventureworksCrawlJobData) // TODO: pass on any extra dependencies
        {
            if (adventureworksCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(adventureworksCrawlJobData));
            }

            _jobData = adventureworksCrawlJobData;
           

            _log = log ?? throw new ArgumentNullException(nameof(log));
        }

        public IEnumerable<T> GetObject<T>() where T : BaseSqlEntity
        {
            var tableName = ((DisplayNameAttribute)typeof(T).GetCustomAttribute(typeof(DisplayNameAttribute))).DisplayName;


            using (var connection = new SqlConnection(_jobData.ConnectionString))
                using (var command = connection.CreateCommand())
                {
                    SqlDataReader reader = null;
                    try
                    {
                        connection.Open();
                        reader = ActionExtensions.ExecuteWithRetry(() =>
                        {
                            command.CommandText = $@"SELECT TOP 1000 * FROM {tableName}";

                            command.CommandTimeout = 180;

                            return command.ExecuteReader();
                        },
                        retryIntervalMilliseconds: _retryIntervalMs,
                        retryCount: 3,
                        isTransient: ex => ex is SqlException || ex.IsTransient());
                    }
                    catch (Exception exception)
                    {
                        _log.Error(() => exception.Message, exception);
                        yield break;
                    }


                    while (reader.Read())
                    {
                        T sqlEntity = default;

                        try
                        {
                            sqlEntity = (T)Activator.CreateInstance(typeof(T), reader);
                        }
                        catch (Exception exception)
                        {
                            _log.Error(() => exception.Message, exception);
                            continue;
                        }

                        yield return sqlEntity;
                    }
                }
        }


        public AccountInformation GetAccountInformation()
        {
            //TODO - return some unique information about the remote data source
            // that uniquely identifies the account
            return new AccountInformation("", ""); 
        }
    }
}
