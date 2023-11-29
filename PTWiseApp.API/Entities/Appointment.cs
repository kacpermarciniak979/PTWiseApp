using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWiseApp.API.Entities
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
    }
}
