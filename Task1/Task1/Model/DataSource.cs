using System;
using Task1.Interfaces;
using Task1Tests1.Common;

namespace Task1.Model
{
    public class DataSource : IDataSource
    {
        public const int NUMBER_OF_POSITIONS = 1000;
        public const int NUMBER_OF_PRICES = 100000;

        public Position[] Positions { get; set; }
        public Price[] Prices { get; set; }


        public DataSource()
        {
            //Fill datasource
            Positions = Dataset.GetPositions(NUMBER_OF_POSITIONS);
            Prices = Dataset.GetPrices(NUMBER_OF_PRICES);
        }
    }
}
