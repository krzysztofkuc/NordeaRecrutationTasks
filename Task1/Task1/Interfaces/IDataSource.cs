using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1.Interfaces
{
    public interface IDataSource
    {
        Position[] Positions { get; set; }
        Price[] Prices { get; set; }
    }
}
