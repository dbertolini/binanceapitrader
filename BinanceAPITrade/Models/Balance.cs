using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceAPITrade.Models
{
    public class Balance
    {
        public string asset { get; set; }
        public decimal free { get; set; }
        public decimal locked { get; set; }
    }
}
