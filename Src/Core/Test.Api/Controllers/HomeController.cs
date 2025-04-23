using System.Threading.Tasks;
using System.Web.Http;


namespace Test.Api.Controllers
{
    [RoutePrefix("Api/Home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("Test")]
        public async Task<IHttpActionResult> TestConnection()
        {
            return Ok("Connect SuccessFully");
        }
    }
}
