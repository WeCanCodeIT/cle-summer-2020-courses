using cle_summer_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IRepository<Instructor>
    {
        public InstructorRepository(UniversityContext db) : base(db)
        {
        }

    }
}
