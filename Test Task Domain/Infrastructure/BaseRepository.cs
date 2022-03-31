
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//using GoGreen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Test_Task_Domain.Models;

namespace Test_Task_Domain.Infrastructure
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Get(object id) => _context.Set<T>().Find(id);

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Add(T entity) => _context.Entry<T>(entity).State = EntityState.Added;

        public void Remove(T entity) => _context.Entry<T>(entity).State = EntityState.Deleted;


        public void Update(T entity) => _context.Entry<T>(entity).State = EntityState.Modified;

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _context.Entry<T>(entity).State = EntityState.Added;
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                _context.Entry<T>(entity).State = EntityState.Deleted;
        }
        public IQueryable<T> FindAsQueryable() => _context.Set<T>().AsQueryable<T>();

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsQueryable();
        }
        //public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        //{
        //    return _context.Set<T>().Where(predicate).AsQueryable();
        //}

        public DbSet<T> GetAllQ()
        {
            return _context.Set<T>();
        }
    }
}
