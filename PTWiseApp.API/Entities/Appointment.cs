using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWise.Models.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Trainer Trainer { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
    }
}
