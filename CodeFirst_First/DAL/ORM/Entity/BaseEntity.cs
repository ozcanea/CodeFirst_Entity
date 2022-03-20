using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_First.DAL.ORM.Entity
{
    internal class BaseEntity
    {
        [Key]
        [Column(Order = 1)] //Column ile database'de sütun sırasını belirtebilirsiniz
        public int ID { get; set; }
        [Column(Order = 2)]
        public string Name { get; set; }
        [Column(TypeName = "datetime2")] //Column aynı zamanda sütun tipini de belirleyebilir
        public DateTime? Added_Date { get; set; }
        public bool isActive { get; set; }
    }
}
