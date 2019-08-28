using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;
using Task1.Model;

namespace Task1
{
    //I think should not be Icalculable, just private functions to test
    public class Calculation
    {
        private IDataSource _source;

        public Calculation(IDataSource source)
        {
            _source = source;
        }

        #region Private methods

        private Price[] GetPrices()
        {
            return _source.Prices;
        }

        private Position[] GetPositions()
        {
            return _source.Positions;
        }

        private IEnumerable<PositionPrice> GetProductWithPosition(Position[] positions, Price[] prices)
        {
            // Here I use cast to "decimal" type because it is recommended type for numbers that can be represent
            // as an integer times a power of 10, can be enough fast for multiplying product value and amount.
            // "double" operations are faster but we can loose part of number(money) when we calculate many oprations.
            // Decimal can store more bigger numbers as float/double.
            // It is recommenden to use decimal types to store big numbers that represent money.

            return positions.Join(prices,
                            pos => new { pos.ProductKey, pos.Date.Date },
                            pri => new { pri.ProductKey, pri.Date.Date },
                            (pos, pri) => new PositionPrice
                            {
                                Price = pri,
                                Position = pos,
                                MarketValue = (decimal)pri.Value * pos.Amount
                            });
        }

        #endregion Private methods


        #region Public methods

        public IEnumerable<PositionPrice> GetProductWithPosition()
        {
            var prices = GetPrices();
            var positions = GetPositions();

            return GetProductWithPosition(positions, prices);
        }

        #endregion Public methods

    }
}
