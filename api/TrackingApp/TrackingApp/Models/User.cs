using System;
using System.ComponentModel.DataAnnotations;

namespace TrackingApp.Models
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Key]
        [Required]
        public int ID { get; set; }
    }
}
