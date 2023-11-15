using Business.Abstracts;
using Business.Constants;
using Core.Utilies.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        //Ctor tab
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CoursesListed);
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int Id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == Id));// ürünleri tek tek dolaşırken c ye atıyor.
        }

        public IDataResult<List<Course>> GetAllInstructorId(int Id)
        {
           
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.InstructorId == Id));

        }
        public IResult Add(Course course)
        {
            if(course.Name.Length<2)
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IDataResult<List<CourseDetailDto>> GetDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }
    }
}
