using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ze_Delivery_Domain.Interfaces
{
    public interface IMongoConnection<T>
    {
        List<T> SelectList(Expression<Func<T, bool>> filter);
        T Select(Expression<Func<T, bool>> filter);
        bool Exists(Expression<Func<T, bool>> filter);
        void Insert(T t);
        void Update(Expression<Func<T, bool>> filter, T tIn);
        void Delete(Expression<Func<T, bool>> filter);
    }
}