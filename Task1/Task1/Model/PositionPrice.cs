using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class PositionPrice
    {
        public Position Position { get; set; }
        public Price Price { get; set; }
        public decimal MarketValue { get; set; }
}
}
