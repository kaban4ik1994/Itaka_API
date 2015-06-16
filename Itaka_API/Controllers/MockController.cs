using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;
using Itaka_API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Itaka_API.Controllers
{

    [EnableCors("*", "*", "*")]
    public class MockController : ApiController
    {
        public IHttpActionResult Get([FromUri]ItakaParameters parameters)
        {
            const BindingFlags flags = BindingFlags.GetField | BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.NonPublic |
                                       BindingFlags.IgnoreCase | BindingFlags.InvokeMethod | BindingFlags.Instance;

            var propertyNames = parameters.GetType().GetProperties(flags).Select(info => string.Format("{0}={1}&", info.Name, parameters.GetType()
                    .InvokeMember(info.Name, flags, null, parameters, null) ?? string.Empty));
            var paramString = string.Empty;
            propertyNames.ToList().ForEach(s => paramString += s);
            paramString = paramString.Remove(paramString.Length - 1);
            //foreach (var name in propertyNames)
            //{
            //    var data = parameters.GetType()
            //        .InvokeMember(name, flags, null, parameters, null);

            //    paramString += string.Format("{0}={1}&", name, data);
            //}

            var url = string.Format("http://www.itaka.pl/ru/strony/4466.php?{0}", paramString);
            var client = new HttpClient();
            var jsonData = client.GetStringAsync(url).Result;

            return Ok(JsonConvert.DeserializeObject(jsonData));
        }
    }
}
