using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWiseApp.API.Entities
{
    public class Client
    {
        [Key] 
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }
        public string? Country { get; set; }

        public string? Postcode { get; set; }
        public Trainer Trainer { get; set; } = null!;
        public int TrainerId { get; set; }
        public DateTime DateOfBirth { get; set; }
        [RegularExpression(@"[A-Za-z0-9._'%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email address is not valid.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string? EmailAddress { get; set; }
        [Display(Name = "Telephone")]
        [DataType(DataType.PhoneNumber)]
        public string? TelephoneNumber { get; set; }
        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();
        public ICollection<Payment> Payments { get; } = new List<Payment>();
    }
}
