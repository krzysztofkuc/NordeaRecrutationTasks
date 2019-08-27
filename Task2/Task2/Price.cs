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

            if (ProductKey == other.ProductKey && Date.Date.CompareTo(other.Date.Date) == 0)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hashPK = ProductKey == null ? 0 : ProductKey.GetHashCode();
            int hashData = ProductKey == null ? 0 : ProductKey.GetHashCode();

            return hashPK ^ hashData;
        }
    }
}
