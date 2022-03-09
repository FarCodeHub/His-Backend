using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Extensions
{
    public class JsonMapper
    {
        // json to model
        public static T Map<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T Map<T>(object obj)
        {
            return JsonConvert.DeserializeObject<T>(Map(obj));
        }

        // object to json
        public static string Map(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        // object to json
        public static JObject ToJson(object obj)
        {
            return JObject.Parse(JsonConvert.SerializeObject(obj));
        }
    }
}
