using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;
using Test.Api;

namespace WindowsService1
{
    public class WebApiHostService : ServiceBase
    {
        private HttpSelfHostServer _server;
        private readonly Uri _baseAddress = new Uri("http://localhost:9000");

        protected override void OnStart(string[] args)
        {
            var config = new HttpSelfHostConfiguration(_baseAddress);

            // کانفیگ Web API شما از Global.asax
            WebApiConfig.Register(config);

            _server = new HttpSelfHostServer(config);
            _server.OpenAsync().Wait();
        }

        public void PublicOnStart(string[] args)
        {
            OnStart(args);
        }

        protected override void OnStop()
        {
            _server?.CloseAsync().Wait();
            _server?.Dispose();
        }

        public void PublicOnStop()
        {
            OnStop();
        }
    }
}
