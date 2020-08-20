using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Mssql.CodeFirst.Models
{
    internal class Teacher
    {
        [Key]
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }
    }
}
