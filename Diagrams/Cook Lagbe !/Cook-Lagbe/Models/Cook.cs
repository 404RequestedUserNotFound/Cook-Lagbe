using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cook_Lagbe.Models
{
    public class Cook
    {
        [Key]
        public int cook_id { get; set; }

        [Required]
        public string cook_name { get; set; }

        [Required]
        [StringLength(100)]
        public string cook_address { get; set; }

        [Required]
        public string cook_phone { get; set; }

        [Required]
        public string cook_image { get; set; }

        [Required]
        [StringLength(100)]
        public string cook_description { get; set; }

        [Required]
        public string cook_NID { get; set; }


        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}