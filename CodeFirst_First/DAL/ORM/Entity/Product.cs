using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_First.DAL.ORM.Entity
{
    internal class Product:BaseEntity
    {
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }
    }
}
