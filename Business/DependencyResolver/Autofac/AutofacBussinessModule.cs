using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBussinessModule: Module
    {
        //- startup.cs services.AddSingleton<IProductService,ProductManager>();
        //services.AddSingleton<IProductDal, EfProductDal>();
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();


        }

    }
}
