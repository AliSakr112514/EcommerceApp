using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys
{
    public interface IRepository <T>
    {
          Task<IEnumerable<T>> GetAsync();
          Task<T> GetByIDAsync(int Id);
          Task<IEnumerable<T>> GetProdByCatId(int CatId);
          Task<IEnumerable<T>> GetProdBySubCatId(int SubCatId);
   




    }
}
