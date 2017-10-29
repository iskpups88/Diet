using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Diet.Models
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("UserName"),Unique]
        public string UserName { get; set; } = string.Empty;
        [Column("Password")]
        public string Password { get; set; } = string.Empty;
        [Column("Age")]
        public int Age { get; set; }
        //public string StrAge { get; set; }
        [Column("Sex")]
        public bool Sex { get; set; } = true;
        [Column("Weight")]
        public int Weight { get; set; }
        //[Column("Height")]
        //public int Height { get; set; }
    }
}
