using DBContext;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys
{
   public class UnitOfWork :IUnitOfWork
    {
        myDbContext Context;
        IRepository<Product> PrdRepo;
        IRepository<Category> CatRepo;
        IRepository<SubCategory> SubCatRepo;
       // IRepository<Brands> BrandRepo;
        public UnitOfWork(myDbContext context, IRepository<Product> _PrdRepo,
            IRepository<Category> _CatRepo, IRepository<SubCategory> _SubCatRepo)//, IRepository<Brands> _BrandRepo)
        {
            Context = context;
            PrdRepo = _PrdRepo;
            CatRepo = _CatRepo;
            SubCatRepo = _SubCatRepo;
          //  BrandRepo = _BrandRepo;


        }
        public IRepository<Product> GetPrdRepo()
        {
            return PrdRepo;
        }
        public IRepository<Category> GetCatRepo()
        {
            return CatRepo;
        }

        public IRepository<SubCategory> GetSubCatRepo()
        {
            return SubCatRepo;
        }
        /*public IRepository<Brands> GetBrandRepo()
        {
            return BrandRepo;
        }*/

        public async Task Save()
        {
            await Context.SaveChangesAsync();
        }

    }
}
