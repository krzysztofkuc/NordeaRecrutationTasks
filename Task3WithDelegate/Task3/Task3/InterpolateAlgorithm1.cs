using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class InterpolateAlgorithm1 : IInterpolable
    {
        public Price[] Interpolate(Price[] source)
        {
            return GetInterpolatedPricesAlgorithm1(new Price[] { });
        }

        private Price[] GetInterpolatedPricesAlgorithm1(Price[] pricesFromSource)
        {
            // some logic here
            return new Price[] { };
        }
    }
}
