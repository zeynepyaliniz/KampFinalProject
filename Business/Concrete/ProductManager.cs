using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?

            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _productDal.GetAll(p => p.CategoryId == Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameMinLength);

            }
            _productDal.Add(product);

            return new Result(true, Messages.ProductAdded);

        }

        public Product GetById(int Id)
        {
            return _productDal.GetById(p => p.ProductId == Id);
        }

        IDataResult<List<Product>> IProductService.GetAll()
        {
            if (DateTime.Now.Hour.Equals(22))
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), true, Messages.ProductListed);

        }

        IDataResult<List<Product>> IProductService.GetAllByCategoryId(int Id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.ProductId == Id), true, Messages.ProductListed);
        }

        IDataResult<List<Product>> IProductService.GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice >= min && p.UnitPrice <= max ),true);
        }

        IDataResult<Product> IProductService.GetById(int Id)
        {
            return new SuccessDataResult<Product>(_productDal.GetById(p => p.ProductId == Id), true, Messages.ProductListed);

        }

      
    }
}
