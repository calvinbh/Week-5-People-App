using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_person_app.Data.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public string DOB { get; set; }

        public Person(string firstname, string lastname, string dob)
        {
            FirstName = firstname;
            LastName = lastname;
            DOB = dob;
        }

        public Person()
        { 
        }
    }
}
