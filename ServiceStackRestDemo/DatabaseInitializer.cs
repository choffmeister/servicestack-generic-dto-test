using System;
using System.Data.Entity;
using ServiceStackRestDemo.Models;

namespace ServiceStackRestDemo
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            User user1 = new User()
            {
                Id = Guid.NewGuid(),
                UserName = "user1"
            };
            context.Users.Add(user1);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}