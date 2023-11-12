using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PM.Models
{
    public class Product
    { 
        [Key]
        public string MaSP { get ; set ; }
        public string TenSP { get ; set ; }
        public double GiaTien { get ; set ; }
        public int SoLuong { get ; set ; }
    }
}