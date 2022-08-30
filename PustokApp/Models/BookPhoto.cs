using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class BookPhoto
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int Order { get; set; }
        [Column(TypeName = "bit")]

        public bool? PosterStatus { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
