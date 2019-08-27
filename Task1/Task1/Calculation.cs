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
            var corelation = positions.Join(prices,
                            pos => pos.ProductKey,
                            pri => pri.ProductKey,
                            (pos, pri) => new PositionPrice { Price = pri,
                                                            Position = pos,
                                                            MarketValue = pri.Value * (double)pos.Amount });

            return corelation;
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
