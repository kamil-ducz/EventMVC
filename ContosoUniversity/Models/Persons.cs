using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsMVC.Models
{
    public class Persons
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
