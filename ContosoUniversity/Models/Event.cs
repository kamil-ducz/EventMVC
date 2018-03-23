using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsMVC.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public int Name { get; set; }
        public string Organizer { get; set; }
        public DateTime Date { get; set; }

    }
}
