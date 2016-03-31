namespace YayOrNay.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YayOrNay.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YayOrNay.Models.YayOrNayDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(YayOrNay.Models.YayOrNayDb context)
        {


            context.Movies.AddOrUpdate(r => r.Title,
                 new Movie { Title = "Notebook", Genre = "Romance", Certificate = "PG" },
                 new Movie { Title = "Godzilla", Genre = "Action", Certificate = "PG-13"},
                 new Movie
                 {
                     Title = "The Matrix",
                     Genre = "Action",
                     Certificate = "R",
                     //ReleaseDate = new DateTime(01 / 02 / 1999),

                     Reviews =
                     new List<MovieReview>
                    {
                        new MovieReview {Rating = 10, Comment = "Awesome Movie!", ReviewerName = "Keith" }
                    }
                 });
        }
    }
}
