using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cook_Lagbe.Models
{
    public class Review
    {
        [Key]
        public int review_id { get; set; }

        [Required]
        [StringLength(200)]
        public string review_text { get; set; }

        [Required]
        public DateTime review_date { get; set; }

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