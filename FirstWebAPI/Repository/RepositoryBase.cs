using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FirstWebAPI.Data;
using FirstWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebAPI.Repository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly AppDbContext context;

    public RepositoryBase(AppDbContext context)
    {
        this.context = context;
    }




    public IQueryable<T> FindAll()
    {
        return context.Set<T>().AsNoTracking();
    }


    public IQueryable<T> Get(Expression<Func<T, bool>> expression)
    {
        return context.Set<T>().Where(expression).AsNoTracking();
    }


    public IQueryable<T> GetName(Expression<Func<T, bool>> expression)
    {
        return context.Set<T>().Where(expression).AsNoTracking();
    }


    public void Add(T entity)
    {
        context.Set<T>().Add(entity);
    }


    public void Update(T entity)
    {
        context.Set<T>().Update(entity);
    }


    public void Delete(T entity)
    {
        context.Set<T>().Remove(entity);
    }

    public bool Save()
    {
        var saved = context.SaveChanges();
        return saved > 0 ? true : false;
    }
}
