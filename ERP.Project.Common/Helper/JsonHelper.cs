using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Project.Common.Helper
{
    public class JsonHelper
    {
        public static string ObjectToString(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static object JsonToObject(string json)
        {
            return JsonToObject<object>(json);
        }

        public static T JsonToObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
