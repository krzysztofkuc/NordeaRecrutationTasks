using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class PriceDataSource : IPriceDataSource
    {
        public Price[] GetPrices(IInterpolable interpolationObject)
        {
            // do some stuff before interpolation
            Price[] retrievedData = new Price[10];

            // do interpolation
            return interpolationObject.Interpolate(retrievedData);
        }
    }
}
