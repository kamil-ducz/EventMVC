using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

//        The ID property will become the primary key column of the database table that corresponds to this class. By default, the Entity Framework interprets a property that's named ID or classnameID as the primary key.

//The Enrollments property is a navigation property.Navigation properties hold other entities that are related to this entity.In this case, the Enrollments property of a Student entity will hold all of the Enrollment entities that are related to that Student entity.In other words, if a given Student row in the database has two related Enrollment rows (rows that contain that student's primary key value in their StudentID foreign key column), that Student entity's Enrollments navigation property will contain those two Enrollment entities.

    }
}
