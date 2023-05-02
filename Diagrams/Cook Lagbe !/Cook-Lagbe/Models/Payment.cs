using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cook_Lagbe.Models
{
    public class Payment
    {
        [Key]
        public int payment_id { get; set; }
        
        [Required]
        public DateTime payment_date { get; set; }

        [Required]
        public int payment_amount { get; set; }

        [Required]
        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User User { get; set; }

        [Required]
        public int cook_id { get; set; }

        [ForeignKey("cook_id")]
        public virtual Cook Cook { get; set; }
    }
}