using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetAllByCategoryId(int Id);
        List<Category> GetByUnitPrice(decimal min, decimal max);
    }
}
