using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using parlem.domain.Abstract;

namespace parlem.domain.Concrete
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;


        public EfRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> GetDbSet()
        {
            return _context.Set<TEntity>();
        }


        public Task<List<TEntity>> GetListAsync()
        {
            return _context.Set<TEntity>().ToListAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> EditAsync(TEntity entity)
        {
            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException ex)
            {

                throw new Exception();
            }

        }

        public TEntity Edit(TEntity entity)
        {
            try
            {
                _context.Update(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (DbUpdateConcurrencyException ex)
            {

                throw new Exception();
            }

        }

    }
}
