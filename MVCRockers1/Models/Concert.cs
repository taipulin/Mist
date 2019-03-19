﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRockers.Models
{
    public class Concert
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string City { get; set; }

        [Display(Name = "Concert Date")]
        public DateTime ConcertDate { get; set; }

        [Display(Name = "Backstage Passes")]
        public int Tickets { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [RegularExpression(@"\d{3,9}")]
        public string Password { get; set; }
    }
}