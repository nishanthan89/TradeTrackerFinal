using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradeTracker.Models
{
    public class RemainingSharesModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Security { get; set; }
        public int RemainingQuantity { get; set; }
        public double AveragePrice { get; set; }

    }
}