using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PM.Models
{
    public class Supplier
    {
        [Key]
        public string MaNXS { get ; set ; }
        public string TenNXS { get ; set ; }
    }
}