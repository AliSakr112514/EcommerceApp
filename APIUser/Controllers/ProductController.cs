using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIUser.Controllers
{
  
   // [Route("Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IRepository<Product> PrdRepo;
        IRepository<Category> CatRepo;
        IRepository<SubCategory> SubCatRepo;
       // IRepository<Brands> BrandsRepo;
        IUnitOfWork IunitOfWork;
        ResultViewModel Result;
        public ProductController(IUnitOfWork _IunitOfWork )
        {
            IunitOfWork = _IunitOfWork;
            PrdRepo = _IunitOfWork.GetPrdRepo();
            CatRepo = _IunitOfWork.GetCatRepo();
            SubCatRepo = _IunitOfWork.GetSubCatRepo();
           // BrandsRepo = _IunitOfWork.GetBrandRepo();
            Result = new ResultViewModel();
        }
        [Route("Product")]
        [HttpGet]
        public async Task<ResultViewModel> GetAllProduct()
        {
            Result.Data = await PrdRepo.GetAsync();
            Result.IsSucess = true;
            return Result;
        }
        [HttpGet]
        [Route("Product/{id:int}")]
        public async Task<ResultViewModel> GetPrdById(int ID)
        {
            Result.Data = await PrdRepo.GetByIDAsync(ID);
            Result.IsSucess = true;
            return Result;
        }
        [HttpGet]
        [Route("Product/GetByCatID/{CatID}")]
        public async Task<ResultViewModel> GetPrdByCatID(int CatID)
        {
          
            Result.Data = PrdRepo.GetProdByCatId(CatID);
            Result.IsSucess = true;
            return Result;
        }

        //return  All Product By SubCat 
        [HttpGet]
        [Route("ProductBySubCat/{SubCatID}")]
        public async Task<ResultViewModel> GetPrdBySubCatID(int SubCatID)
        {
            
            var SubCat = await SubCatRepo.GetByIDAsync(SubCatID);
            if(SubCat!=null)
            {
                Result.Data = await PrdRepo.GetProdByCatId(SubCat.CatID);
                Result.IsSucess = true;
                return Result;
            }
            // Result.Data = await PrdRepo.GetProdByCatId(SubCat.CatID);
            //  Result.IsSucess = true;
            // return Result;
            Result.IsSucess = false;
            return Result;
        }
        //return  All Category
        [HttpGet]
        [Route("Category")]
        public async Task<ResultViewModel> GetAllCategory()
        {
            Result.Data = await CatRepo.GetAsync();
            Result.IsSucess = true;
            return Result;
        }
        //return  All SubCategory 
        [HttpGet]
        [Route("SubCategory")]
        public async Task<ResultViewModel> GetAllSubCategory()
        {
            Result.Data = await SubCatRepo.GetAsync();
            Result.IsSucess = true;
            return Result;
        }

        //return  All Brands 
       /* [HttpGet]
        [Route("Brands")]
        public async Task<ResultViewModel> GetAllBrands()
        {
            Result.Data = await BrandsRepo.GetAsync();
            Result.IsSucess = true;
            return Result;
        }*/
    }
}
