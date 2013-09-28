using System;
using System.Data.Entity;
using ServiceStackRestDemo.Models;

namespace ServiceStackRestDemo
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 1; i <= 50; i++)
            {
                User user = new User()
                {
                    Id = i,
                    UserName = string.Format("user{0}", i)
                };
                context.Users.Add(user);
            }

            for (int i = 0; i <= 50; i++)
            {
                Post post = new Post()
                {
                    Id = Guid.NewGuid(),
                    Subject = string.Format("Post {0}", i),
                    Content = string.Format("lorem ipsum {0}", i)
                };
                context.Posts.Add(post);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}