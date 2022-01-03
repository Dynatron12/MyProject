using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class DateNow
    {
        [Key]
        public int DateID { get; set; }
        public DateTime Date { get; set; }
    }
}
