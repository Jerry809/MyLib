using Jil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Utility
{
    public class JilSerializer
    {
        private static readonly Options _jilOptions = new Options(includeInherited: true,
           dateFormat: DateTimeFormat.ISO8601);

        /// <summary>
        /// Json序列化(包含繼承的父類別)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Serialize<T>(T data)
        {
            return JSON.Serialize(data, _jilOptions);
        }

        /// <summary>
        /// Json反序列化(包含繼承的父類別)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string data)
        {
            return JSON.Deserialize<T>(data, _jilOptions);
        }
    }
}
