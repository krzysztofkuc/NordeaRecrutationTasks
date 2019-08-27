using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class INterpolateAlgorithm2 : IInterpolable
    {
        public Price[] Interpolate(Price[] source)
        {
            return GetInterpolatedPricesAlgorithm2(new Price[] { });
        }

        private Price[] GetInterpolatedPricesAlgorithm2(Price[] pricesFromSource)
        {
            return new Price[] { };
        }
    }
}
