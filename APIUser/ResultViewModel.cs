using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIUser
{
    public class ResultViewModel
    {
        public bool IsSucess { get; set;  }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
