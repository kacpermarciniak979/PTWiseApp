﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTWiseApp.API.Entities
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Appointment Appointment { get; set; } = null!;
        public int AppointmentId { get; set; }
        public int DurationMins { get; set; }
    }
}
