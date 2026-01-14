using Core.Contract;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly EShopDbContext _context;
        public BaseRepositoryAsync(EShopDbContext _c)
        {
            _context = _c;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<int> Insert(T entity)
        {
            _context.Set<T>().AddAsync(entity);
            return _context.SaveChangesAsync();
        }
    }
}
