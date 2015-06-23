using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Cors;
using Itaka_API.Models;
using Newtonsoft.Json;

namespace Itaka_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ZeroController : ApiController
    {
        public IHttpActionResult Get([FromUri]ItakaParameters parameters)
        {

            var url = string.Format("http://www.itaka.pl/ru/strony/489.php?{0}", parameters);
            var client = new HttpClient();
            var jsonData = client.GetStringAsync(url).Result;

            return Ok(JsonConvert.DeserializeObject(jsonData));
        }
    }
}
