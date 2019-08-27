using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1Tests1.Common
{
    /// <summary>
    ///     This class is only to fill datasource with some example data
    /// </summary>
    public static class Dataset
    {
        public static Price[] GetPrices(int noOfPrices)
        {
            Price[] result = new Price[noOfPrices];

            //Mock 1000 Price objects
            for (int i = 0; i < noOfPrices; i++)
            {
                result[i] = new Price()
                {
                    Date = DateTime.Now.AddSeconds(i),
                    ProductKey = i.ToString(),
                    Value = i + 10
                };
            }

            return result;
        }

        public static Position[] GetPositions(int numberOfPositions)
        {
            Position[] result = new Position[numberOfPositions];

            //Mock 10000 Position objects
            for (int i = 0; i < numberOfPositions; i++)
            {
                result[i] = new Position()
                {
                    Date = DateTime.Now.AddSeconds(i),
                    ProductKey = i.ToString(),
                    Amount = i,
                    PositionId = i
                };
            }

            return result;
        }
    }
}
