﻿using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Conrete.EfCore
{
    public class EfCoreGenericRepository<T, TContext> : IRepository<T>
         where T : class
        where TContext : DbContext, new()
    {
        public void Create(T entity)
        {
            using (var context=new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter=null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(filter).SingleOrDefault();
            }
        }

        public virtual void Update(T entity) //eğer metot virtual olarak tanımlanırsa başka yerde ezilebilr. 
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified; // bu tarzdaki update işleminde ilişkili olan alt tablolar güncellenmez
                context.SaveChanges();
            }
        }
    }
}
