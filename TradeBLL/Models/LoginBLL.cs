namespace TradeBLL.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class LoginBLL : DbContext
    {
        public int Id { get; set; }
        [Required]
        public string NIC { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    
}