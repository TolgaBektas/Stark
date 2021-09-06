using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.ExtensionMethods
{
    public static class SessionExtensionMethod
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string objStr = JsonConvert.SerializeObject(value);
            session.SetString(key, objStr);
        }
        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string objStr = session.GetString(key);
            if (String.IsNullOrEmpty(objStr))
            {
                return null;
            }
            T value = JsonConvert.DeserializeObject<T>(objStr);//T türünde geri dönüştür
            return value;
        }
    }
}
