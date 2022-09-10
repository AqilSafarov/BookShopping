using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="50 den uzun ola bilmez")]
        public string Fullname { get; set; }
       
        [MaxLength(500)]

        public string Desc { get; set; }

        public virtual ICollection<Book> Books{ get; set; }

    }
}
