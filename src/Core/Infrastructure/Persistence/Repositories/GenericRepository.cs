using Application.Interfaces.Repository;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbcontext;

        public GenericRepository(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await dbcontext.Set<T>().AddAsync(entity);
            await dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbcontext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAllByIdAsync(Guid Id)
        {
            return await dbcontext.Set<T>().FindAsync(Id);
        }
    }
}
