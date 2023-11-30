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
        public Trainer Trainer { get; set; } = null!;
        public int TrainerId { get; set; }
        public Client Client { get; set; } = null!;
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; }

        public ICollection<Workout> Workouts { get; } = new List<Workout>();

    }
}
