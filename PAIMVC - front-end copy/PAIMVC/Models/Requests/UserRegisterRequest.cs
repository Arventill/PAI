using System.ComponentModel.DataAnnotations;
using PAIMVC.Enums;

namespace PAIMVC.Models.Requests
{
    public class UserRegisterRequest
    {
        public string Email { get; set; }

        public string Password { get; set; }

        //false should be default
        public bool Status { get; set; }

        public UserType UserType { get; set; }

        [MaxLength(100)]
        public string PersonName { get; set; }

        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        public string City { get; set; }

        [MaxLength(6)]
        public string ZipCode { get; set; }

        public string Address { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        public UserBusinessStatus IsVerified { get; set; }

        public string Hash { get; set; }
    }
}
