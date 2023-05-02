using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cook_Lagbe.Models
{
    public class Booking
    {
        [Key]
        public int booking_id { get; set; }

        public DateTime booking_date { get; set; }

        public int user_id { get; set; }

        [ForeignKey("user_id")]
        public virtual User User { get; set; }

        public int cook_id { get; set; }

        [ForeignKey("cook_id")]
        public virtual Cook Cook { get; set; }

        public bool is_accepted { get; set; }
    }

}