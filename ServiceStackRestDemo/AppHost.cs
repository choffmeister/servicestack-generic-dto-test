using System.Data.Entity;
using System.Reflection;
using Funq;
using ServiceStack.WebHost.Endpoints;

namespace ServiceStackRestDemo
{
    public class AppHost : AppHostHttpListenerBase
    {
        public AppHost()
            : base("demo", Assembly.GetEntryAssembly())
        {
        }

        public override void Configure(Container container)
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}