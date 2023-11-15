using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;

using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, AcademyContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (AcademyContext context = new AcademyContext())
            {
                var result = from c in context.Courses
                             join ca in context.Categories
                             on c.Id equals ca.Id
                             join i in context.Instructors
                             on c.Id equals i.Id
                             select new CourseDetailDto
                             {
                                 Id = c.Id,
                                 CategoryName = ca.Name,
                                 InstructorName = i.Name,
                                 Title = c.Title,
                                 Name = c.Name
                             };

                return result.ToList();
             

             }

        }
    }
}
