using System;

namespace DataService.ModelServices
{
    public class ModelUtilities
    {
        public int? GetInt(object obj)
        {
            return (obj == null || obj is DBNull) ? (int?)null : Convert.ToInt32(obj);
        }

        public int? GetInt(object obj, int defaultValue)
        {
            return (obj == null || obj is DBNull) ? defaultValue : Convert.ToInt32(obj);
        }

        public int GetNotNullInt(object obj)
        {
            return (obj == null || obj is DBNull) ? (int)0 : Convert.ToInt32(obj);
        }

        public decimal? GetDecimal(object obj)
        {
            return (obj == null || obj is DBNull) ? (decimal?)null : Convert.ToDecimal(obj);
        }

        public decimal GetNotNullDecimal(object obj)
        {
            return (obj == null || obj is DBNull) ? 0 : Convert.ToDecimal(obj);
        }

        public double? GetDouble(object obj)
        {
            return (obj == null || obj is DBNull) ? (double?)null : Convert.ToDouble(obj);
        }

        public string GetString(object obj)
        {
            return (obj == null || obj is DBNull) ? string.Empty : obj.ToString();
        }

        public DateTime? GetDateTime(object obj)
        {
            return (obj == null || obj is DBNull) ? (DateTime?)null : Convert.ToDateTime(obj);
        }

        public DateTime GetDateTimeDefault(object obj)
        {
            return (obj == null || obj is DBNull) ? DateTime.MinValue : Convert.ToDateTime(obj);
        }

        public bool? GetBool(object obj)
        {
            return (obj == null || obj is DBNull) ? (bool?)null : Convert.ToBoolean(obj);
        }

        public bool GetNotNullBool(object obj)
        {
            return Convert.ToBoolean(obj);
        }

        public long? GetLong(object obj)
        {
            return (obj == null || obj is DBNull) ? (long?)null : Convert.ToInt64(obj);
        }

        public long GetNotNullLong(object obj)
        {
            return (obj == null || obj is DBNull) ? (long)0 : Convert.ToInt64(obj);
        }

        public object SetStringDbNull(string obj)
        {
            return string.IsNullOrEmpty(obj) || obj == " " ? (object)DBNull.Value : obj;
        }

        public object SetStringEmpty(string obj)
        {
            return obj ?? string.Empty;
        }

        public object SetLongDbNull(long? obj)
        {
            return obj ?? (object)DBNull.Value;
        }

        public object SetIntDbNull(int? obj)
        {
            return obj ?? (object)DBNull.Value;
        }

        public object SetDateTimeDbNull(DateTime? obj)
        {
            return obj ?? (object)DBNull.Value;
        }
    }
}
