using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cook_Lagbe.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

        [Required]
        public string user_image { get; set; }

        [Required]
        [StringLength(200)]
        public string user_address { get; set; }

        [Required]
        public string user_phone { get; set; }

        [Required]
        public string user_profession { get; set; }

        [Required]
        public string user_NID { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }




        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}