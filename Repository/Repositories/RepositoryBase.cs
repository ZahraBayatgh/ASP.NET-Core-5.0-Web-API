using Contracts.IServices;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected CompanyEmployeeDbContext _companyEmployeeDbContext;
        public RepositoryBase(CompanyEmployeeDbContext companyEmployeeDbContext)
        {
            _companyEmployeeDbContext = companyEmployeeDbContext;
        }
        public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ?
        _companyEmployeeDbContext.Set<T>()
        .AsNoTracking() :
        _companyEmployeeDbContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
        !trackChanges ?
        _companyEmployeeDbContext.Set<T>()
        .Where(expression)
        .AsNoTracking() :
        _companyEmployeeDbContext.Set<T>()
        .Where(expression);

        public void Create(T entity) => _companyEmployeeDbContext.Set<T>().Add(entity);

        public void Update(T entity) => _companyEmployeeDbContext.Set<T>().Update(entity);

        public void Delete(T entity) => _companyEmployeeDbContext.Set<T>().Remove(entity);
    }

}
