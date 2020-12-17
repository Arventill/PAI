using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProgramowanieAplikacjiInternetowych.Enums;

namespace ProgramowanieAplikacjiInternetowych.Repository.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        //false should be default
        public bool Status { get; set; }

        public UserType UserType { get; set; }

        [MaxLength(100)]
        public string PersonName { get; set; }

        [Required]
        [MaxLength(36)]
        public string Hash { get; set; }

        public DateTime? DeleteAccountDate { get; set; }

        public DateTime CreateAccountDate { get; set; }

        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        public string City { get; set; }

        [MaxLength(6)]
        public string ZipCode { get; set; }

        public string Address { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        public UserBusinessStatus IsVerified { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
