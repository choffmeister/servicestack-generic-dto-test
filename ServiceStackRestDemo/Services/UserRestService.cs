using System.Collections.Generic;
using System.Linq;
using ServiceStackRestDemo.Models;

namespace ServiceStackRestDemo.Services
{
    public class UserRestService : RestServiceBase<User, int>
    {
        private readonly DatabaseContext context;

        public UserRestService(DatabaseContext context)
        {
            this.context = context;
        }

        public override List<User> Get(GetEntitiesRequest<User> request)
        {
            return this.context.Users.ToList();
        }

        public override User Get(GetEntityRequest<User, int> request)
        {
            return this.context.Users.Single(u => u.Id == request.Id);
        }
    }
}