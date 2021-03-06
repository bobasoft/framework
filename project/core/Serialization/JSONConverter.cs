using System;
using Newtonsoft.Json;

namespace Bobasoft.Serialization
{
    public class JSONConverter : IConverter
    {
        //======================================================
        #region _Public methods_

        public string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public object Deserialize(string value)
        {
            return JsonConvert.DeserializeObject(value);
        }

        public object Deserialize(string value, Type type)
        {
            return JsonConvert.DeserializeObject(value, type);
        }

        public T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        #endregion
    }
}