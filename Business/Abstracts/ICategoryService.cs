using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(Category category);
        List<Category> GetAll();
        List<Category> GetAllByCategoryId(int Id);

        List<Category> GetAllInstructorId(int Id);
    }
}
