using System;
using System.Linq.Expressions;
using FirstWebAPI.Models;

namespace FirstWebAPI.Repository;

public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll();
    IQueryable<T> Get(Expression<Func<T, bool>> expression);
    IQueryable<T> GetName(Expression<Func<T, bool>> expression);
    void Add(T entity);
    //bool Exists(int Id);
    void Delete(T entity);
    void Update(T entity);
}