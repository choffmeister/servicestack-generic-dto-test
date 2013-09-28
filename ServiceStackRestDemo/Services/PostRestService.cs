using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStackRestDemo.Models;

namespace ServiceStackRestDemo.Services
{
    public class PostRestService : RestServiceBase<Post, Guid>
    {
        private readonly DatabaseContext context;

        public PostRestService(DatabaseContext context)
        {
            this.context = context;
        }

        public override List<Post> Get(GetEntitiesRequest<Post> request)
        {
            return this.context.Posts.ToList();
        }

        public override Post Get(GetEntityRequest<Post, Guid> request)
        {
            return this.context.Posts.SingleOrDefault(p => p.Id == request.Id);
        }
    }
}