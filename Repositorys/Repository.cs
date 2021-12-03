using DBContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys
{
    public class Repository<T> :IRepository<T> where T : class
    {
        myDbContext context;
        DbSet<T> Table;
        public Repository(myDbContext _context)
        {
            context = _context;
            Table = context.Set<T>();
        }
        //Get All
        public async Task<IEnumerable<T>> GetAsync()
        {
            return  Table;
        }
        //Get By ID
        public async Task<T> GetByIDAsync(int Id)
        {
            return await Table.FindAsync(Id);
        }
 
          //Get By Lamada Experssion
        public async Task<IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return  Table.Where(expression).AsNoTracking();
        }





    }
}
