using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Offers
{
    public class Offers
    {
        public int OfferId { get; set; }
        public int ProductId { get; set; }
        public float NewPrice { get; set; }
        public int Precentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
