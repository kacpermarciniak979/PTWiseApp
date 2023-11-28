using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWise.Models.Models
{
    public class Trainer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public ICollection<Client> Clients { get; } = new List<Client>();
        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();
        public string GymName { get; set; }

        [RegularExpression(@"[A-Za-z0-9._'%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email address is not valid.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Display(Name = "Telephone")]
        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber { get; set; }
    }
}
