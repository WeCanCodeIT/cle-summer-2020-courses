using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Models
{
    public class Course
    {
        //[Required]
        public string Name { get; set; }
        public int Id { get; set; }

        //[MaxLength(20)]
        public string Description { get; set; }

        //[Display(Name = "Instructor")]
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public virtual List<StudentCourse> StudentCourses { get; set; }

        public Course()
        {
        }

        public Course(string name, int id, string description)
        {
            Name = name;
            Id = id;
            Description = description;
        }
    }
}
