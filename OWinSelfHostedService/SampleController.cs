using System.Web.Http;
using System.Web.Http.Cors;

namespace OWinSelfHostedService
{
    [RoutePrefix("api")]
    //TODO: Uncomment if you want to support CORS (Cross-origin Resource Sharing)
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SampleController : ApiController
    {
        // /api/test/foo
        // /api/test/foo/123

        [Route("test/foo/{id:int?}")]
        [HttpGet]   //TODO: When using CORS the HttpGet attribute can be removed
        public string Foo(int? id = null)
        {
            return id.HasValue ? string.Format("Value was: {0}", id.Value) : "No value supplied";
        }
    }
}