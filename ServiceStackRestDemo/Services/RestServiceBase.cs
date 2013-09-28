using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStackRestDemo.Models;

namespace ServiceStackRestDemo.Services
{
    public abstract class RestServiceBase<TEntity, TKey> : Service
        where TEntity : class, IEntity<TKey>, new()
        where TKey : struct
    {
        public static void RegisterRoutes(AppHost appHost)
        {
            string entityName = typeof(TEntity).Name.ToLowerInvariant();

            appHost.Routes.Add<GetEntitiesRequest<TEntity>>(string.Format("/{0}", entityName));
            appHost.Routes.Add<GetEntityRequest<TEntity, TKey>>(string.Format("/{0}/{{Id}}", entityName));
        }

        public abstract List<TEntity> Get(GetEntitiesRequest<TEntity> request);

        public abstract TEntity Get(GetEntityRequest<TEntity, TKey> request);
    }

    public class GetEntitiesRequest<TRequestEntity> : IReturn<List<TRequestEntity>>
    {
    }

    public class GetEntityRequest<TRequestEntity, TRequestKey> : IReturn<TRequestEntity>
    {
        public TRequestKey Id { get; set; }
    }
}