using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Comment
{
    public class Comment
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }


    }
}
