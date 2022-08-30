﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        [MaxLength(10)]

        public string CodePrefix { get; set; }
        public int CodeNum { get; set; }
        [Column(TypeName = "bit")]

        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountedPrice { get; set; }
        public DateTime CratedAt { get; set; }
        [Column(TypeName = "bit")]

        public bool IsNew { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public virtual ICollection <BookPhoto> BookPhotos { get; set; }


    }
}
