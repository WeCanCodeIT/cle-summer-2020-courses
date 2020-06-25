using cle_summer_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class StudentCourseRepository : IRepository<StudentCourse>
    {
        private UniversityContext db;

        public StudentCourseRepository(UniversityContext db)
        {
            this.db = db;
        }

        public void Create(StudentCourse studentCourse)
        {
            db.StudentCourses.Add(studentCourse);
            db.SaveChanges();
        }

        public void Delete(StudentCourse studentCourse)
        {
            db.StudentCourses.Remove(studentCourse);
            db.SaveChanges();
        }

        public IEnumerable<StudentCourse> GetAll()
        {
            return db.StudentCourses;
        }

        public StudentCourse GetById(int id)
        {
            return db.StudentCourses.Single(c => c.Id == id);
        }

        //public bool IsStudentAlreadyEnrolled(int courseId, int studentId)
        //{
        //    return db.StudentCourses.Any(c => c.CourseId == courseId & c.StudentId == studentId);
        //}

        public void Update(StudentCourse obj)
        {
            throw new NotImplementedException();
        }
    }
}
