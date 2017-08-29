using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeDAL
{
    public class loginDALModel
    {
            public int Id { get; set; }
            [Required]
            public string NIC { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

    }
}
