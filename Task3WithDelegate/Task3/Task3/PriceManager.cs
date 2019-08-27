using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class PriceManager
    {
        private readonly IPriceDataSource priceDataSource;

        public PriceManager(IPriceDataSource priceDataSource)
        {
            this.priceDataSource = priceDataSource;
        }

        public Price[] GetPrices()
        {
            // everytime when we want to change algorith we should pass object that implements IInterpolable interface
            return priceDataSource.GetPrices(GetInterpolatedPricesAlgorithm1);
        }

        private Price[] GetInterpolatedPricesAlgorithm1(Price[] pricesFromSource)
        {
            // some logic here
            return new Price[] { };
        }

        private Price[] GetInterpolatedPricesAlgorithm2(Price[] pricesFromSource)
        {
            // some logic here
            return new Price[] { };
        }
    }
}
