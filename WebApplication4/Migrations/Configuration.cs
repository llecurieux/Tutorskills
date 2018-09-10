namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication4.Models.TutorskillsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication4.Models.TutorskillsDb context)
        {
            context.Posts.AddOrUpdate(r => r.Title,
                new Models.Post { Title = "what is this?", Content = "blablablabla" },
                new Models.Post { Title = "How can I do that?", Content = "This way..." }
                );
        }
    }
}
