using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    interface IInterpolable
    {
        Price[] Interpolate(Price[] source);
    }
}
