using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class PriceDataSource : IPriceDataSource
    {
        public Price[] GetPrices(Func<Price[], Price[]> interpolate)
        {
            // do some stuff before interpolation
            Price[] retrievedData = new Price[10];

            // do interpolation
            return interpolate(retrievedData);
        }
    }
}
