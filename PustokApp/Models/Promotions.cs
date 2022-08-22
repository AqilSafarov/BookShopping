using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Promotions
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string RedirectUrl { get; set; }
        [MaxLength(250)]

        public string Photo { get; set; }
        public int SectionNo { get; set; }
    }
}
