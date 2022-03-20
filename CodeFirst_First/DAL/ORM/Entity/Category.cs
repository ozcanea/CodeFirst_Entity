using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_First.DAL.ORM.Entity
{
    internal class Category:BaseEntity
    {
        [MaxLength(255)]
        public string Description { get; set; }
    }
}
