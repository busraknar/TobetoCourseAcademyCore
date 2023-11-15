using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager:ICategoryService
    {

        ICategoryDal _categoryDal;
        //ctor tab
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        //public void Add(Category category)
        //{
        //    //Business çalıştırılır
        //    AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
        //    categoryDal.Add(category);
        //}

        public void Add(Course course1)
        {
            Console.WriteLine(course1.Name + " Eklendi.");
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }


        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetAll(filter);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetAllByCategoryId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllInstructorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
