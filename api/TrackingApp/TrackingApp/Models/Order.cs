using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackingApp.Models
{
    public class Order
    {
        [Required]
        public string UsersName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string TrackingID { get; set; }

        [ForeignKey("User")]
        [Column(Order = 1)]
        [Required]
        public int ID { get; set; }
    }
}
