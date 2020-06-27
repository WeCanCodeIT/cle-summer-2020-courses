﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_summer_2020_courses.Repositories
{
    public interface IRepository<T> : ISelectList where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(T obj);
        void Update(T obj);
        bool IsStudentAlreadyEnrolled(int courseId, int studentId);
    }
}
