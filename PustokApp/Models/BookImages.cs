using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class BookImages
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Phote { get; set; }
        //public int BookId { get; set; }
        //public Book Book { get; set; }
    }
}
