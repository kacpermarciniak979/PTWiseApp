using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PTWiseApp.API.Entities
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ExerciseType ExerciseType { get; set; } 
        public int Sets { get; set; }
        // Reps should be string - in case of "to failure", or similar.
        public string Reps { get; set; }
        public int RestPeriodSeconds { get; set; }
        public Difficulty Difficulty { get; set; }
        [JsonIgnore]
        public Workout Workout { get; set; }
        public int WorkoutId { get; set; } 
    }
}
