using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CluedIn.Crawling.AdventureWorksProduction.Core
{
    public static class ReaderHelper
    {
        public static T TryParse<T>(this string text, T defaultValue = default)
        {
            // Get specific converter for the type
            var converter = TypeDescriptor.GetConverter(typeof(T));
            // If there is a converter and conversion is valid
            return (converter?.IsValid(text) == true) ? (T)converter.ConvertFromInvariantString(text)
                 : defaultValue;
        }

        public static T GetNullableValue<T>(this IDataReader reader, string columnName)
        {
            return Enumerable.Range(0, reader.FieldCount).Any(i => string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase)) ? reader[columnName].ToString().TryParse<T>() : default;
        }

        public static string GetStringValue(this IDataReader reader, string columnName)
        {
            return Enumerable.Range(0, reader.FieldCount).Any(i => string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase)) ? reader[columnName].ToString() : default;
        }

        public static string GetStringFromByteArray(this IDataReader reader, string columnName)
        {
            var typeName = reader.GetDataTypeName(reader.GetOrdinal(columnName));

            if ((typeName != "timestamp" && typeName != "rowversion") || string.IsNullOrEmpty(reader.GetStringValue(columnName)))
                return null;

            return reader[columnName] is byte[] arr ? BitConverter.ToInt64(arr, 0).ToString() : null;
        }
    }

}
