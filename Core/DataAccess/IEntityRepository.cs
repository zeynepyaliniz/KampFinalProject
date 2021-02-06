using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class , IEntity, new()// class referenas tip değerler alması için where koşulu eklendi.
    {
        //new(), new'lenebilir
        List<T> GetAll(Expression<Func<T,bool>> filter = null); // expression yapısı p=>p.Id yi kullanabilmek için Expression yapısı 
        // refactoring
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(Expression<Func<T, bool>> filter = null);

    }
}
