using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradeTracker.Models
{
    public class TransactionDetailsModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Security { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double BrokerageFee { get; set; }
        public double AveragePrice { get; set; }
        public double TotalCost { get; set; }


    }
}