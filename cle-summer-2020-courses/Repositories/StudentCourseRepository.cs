using cle_summer_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class StudentCourseRepository : Repository<StudentCourse>, IRepository<StudentCourse>
    {
        UniversityContext db;
        public StudentCourseRepository(UniversityContext db) : base(db)
        {
            this.db = db;
        }

        public override bool IsStudentAlreadyEnrolled(int courseId, int studentId)
        {
            return db.StudentCourses.Any(c => c.CourseId == courseId & c.StudentId == studentId);
        }

    }
}
