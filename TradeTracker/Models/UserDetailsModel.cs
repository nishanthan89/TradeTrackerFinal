using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradeTracker.Models
{
    public class UserDetailsModel
    {
        public int Id { get; set; }
        public string NIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int status { get; set; }

    }
}