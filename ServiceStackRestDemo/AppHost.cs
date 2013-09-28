using System.Data.Entity;
using System.Reflection;
using Funq;
using ServiceStack.WebHost.Endpoints;
using ServiceStackRestDemo.Services;

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
            Database.SetInitializer<DatabaseContext>(new DatabaseInitializer());

            container.Register<DatabaseContext>(c => new DatabaseContext()).ReusedWithin(ReuseScope.Hierarchy);

            UserRestService.RegisterRoutes(this);
            PostRestService.RegisterRoutes(this);
        }
    }
}