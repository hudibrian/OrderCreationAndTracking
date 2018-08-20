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
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }

        [Required]
        [Key]
        public string TrackingID { get; set; }

        [Required]
        public User User { get; set; }
    }
}
