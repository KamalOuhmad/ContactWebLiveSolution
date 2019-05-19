namespace ContactWebLiveDemo.Migrations
{
    using ContactWebLiveDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactWebLiveDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactWebLiveDemo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
   
            var contacts = new List<Contact>
            {
   
                new Contact() { Id = 1, UserId = Guid.NewGuid(), FirstName = "Jane ", LastName = "Austen", Email = "ouhmsad@gmail.com", Phone = "00012345", Birthday = DateTime.Parse("2011-09-01"), Address = "12 blvd", City = "Arlington", State = "VA", Zip = "2111"}
            };
            contacts.ForEach(s => context.Contacts.AddOrUpdate(p => p.Id, s));
            context.SaveChanges();
        }
    }
}
