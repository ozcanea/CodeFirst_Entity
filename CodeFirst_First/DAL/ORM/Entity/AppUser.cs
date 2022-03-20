using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_First.DAL.ORM.Entity
{
    //Table Attribute içerisine yazılmış olan string değeri tablo oluşturulurken tablo ismi olarak belirleyecektir
    [Table("Users")]
    internal class AppUser:BaseEntity
    {


        //MaxLength default olarak nvarchar(MAX) olan stringleri belirtilen sayı kadar yer alabileceğini belirleyecektir
        [MaxLength(30)]
        public string Lastname { get; set; }
        //NotMapped entity içerisinde var olmasına rağmen database'de tabloda bir sütun olarak oluşturulmayacaktır
        [NotMapped]
        public string Fullname
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Lastname))
                {
                    return Name;
                }
                else
                {
                    return Name + " " + Lastname;
                }
            }
        }
        //Reference type olmasına rağmen Required denilerek "Not Null" bir sütun oluşturulabilir
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime? Birth_Date { get; set; }
        public bool Gender { get; set; }

    }
}
