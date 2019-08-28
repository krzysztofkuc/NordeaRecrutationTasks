using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    /// <summary>
    /// Market price of certain product at certain date
    /// </summary>
    public class Price : IEquatable<Price>
    {
        public DateTime Date { get; set; }
        public string ProductKey { get; set; }
        public double Value { get; set; }

        public bool Equals(Price other)
        {
            //Method Date.Date.Equals() can be faster and avoid to equals to 0 operation
            //This operation can speed up Distinct()
            if (ProductKey == other.ProductKey && Date.Date.Equals(other.Date.Date))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            //less operations - faster algorithm
            return ProductKey.GetHashCode() ^ Date.GetHashCode();
        }
    }
}
