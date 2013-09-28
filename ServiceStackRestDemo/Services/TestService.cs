using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace ServiceStackRestDemo.Services
{
    public class TestService : Service
    {
        public string Get(TestRequest request)
        {
            return string.Format("Hello {0}!", request.Name);
        }
    }

    [Route("/test/{Name}")]
    public class TestRequest : IReturn<string>
    {
        public string Name { get; set; }
    }
}