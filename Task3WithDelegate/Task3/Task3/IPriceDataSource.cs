using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    interface IPriceDataSource
    {
        /// <summary>
        ///     Makes inerpolation after price received from datasource
        /// </summary>
        /// <param name="interpolation"></param>
        /// <returns></returns>
        Price[] GetPrices(Func<Price[], Price[]> interpolate);
    }
}
