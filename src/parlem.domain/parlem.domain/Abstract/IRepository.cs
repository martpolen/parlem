using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace parlem.domain.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //IQueryable<TEntity> TableHP();

        DbSet<TEntity> GetDbSet();

        Task<List<TEntity>> GetListAsync();

        Task CreateAsync(TEntity entity);

        Task<TEntity> EditAsync(TEntity entity);

        TEntity Edit(TEntity entity);
    }
}
