using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Product
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float  Price { get; set; }
        public int Quantity { get; set; }
        public string Description  { get; set; }
        public  int UserId  { get; set; }
        public int CatId  { get; set; }
        public int BrandId { get; set; }
        public int StockId { get; set; }
        public int SubCatId { get; set; }
       



    }
}
