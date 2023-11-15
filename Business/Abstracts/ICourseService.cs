using Core.Utilies.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IDataResult<List<CourseDetailDto>> GetDetails();
        IDataResult< List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByCategoryId(int Id);

        IDataResult<List<Course>> GetAllInstructorId(int Id);

        //IDataResult<List<Course>> GetAll();
        //IDataResult<List<Course>> GetAllByCategoryId(int id);
        //IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);
        //IDataResult<List<CourseDetailDto>> GetProductDetails();
        //IDataResult<Course> GetById(int productId);
        //IResult Add(Course course);

    }
}
