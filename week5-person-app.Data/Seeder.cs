using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using week5_person_app.Data.Model;

namespace week5_person_app.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext db, bool people = false)
        {
            if (people) SeedPeople(db);
        }

        private static void SeedPeople(ApplicationDbContext db)
        {
            db.People.AddOrUpdate(x => x.FirstName,
                new Person("Calvin", "Williams", "May 20, 1984"),
                new Person("Karli", "Williams", "March 20, 1987"),
                new Person("Bob", "Doe", "July 2, 1972"),
                new Person("Jill", "Perkins", "Dec 31, 1974"),
                new Person("Melvin", "Stevens", "Jan 17, 1989"),
                new Person("Frank", "Kern", "Sept 3, 1967"),
                new Person("Robert", "Taft", "Oct 28, 1957"),
                new Person("Cliff", "Moore", "May 17, 1982")

                );
            db.SaveChanges();
        }
    }
}
