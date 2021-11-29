using DBContext;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys
{
    public class Repository<T> :IRepository<T> where T : BaseModel
    {
        myDbContext context;
        DbSet<T> Table;
        public Repository(myDbContext _context)
        {
            context = _context;
            Table = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return Table;
        }

        public async Task<T> GetByIDAsync(int Id)
        {
            return await Table.FindAsync(Id);
        }
 
        public async Task<IEnumerable<T>> GetProdByCatId(int CatId)
        {
            return  Table.Where(i=>i.CatID== CatId).ToList();
        }
   
        public async Task<IEnumerable<T>> GetProdBySubCatId(int SubCatId)
        {
            return Table.Where(i => i.CatID == SubCatId).ToList();
        }
     




    }
}
