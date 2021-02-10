using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly EfCategoryDal categoryDal;
        public CategoryManager(EfCategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }
        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategoryId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}
