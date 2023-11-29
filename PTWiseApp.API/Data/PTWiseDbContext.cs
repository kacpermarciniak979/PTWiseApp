using Microsoft.EntityFrameworkCore;
using PTWiseApp.API.Entities;

namespace PTWiseApp.API.Data
{
    public class PTWiseDbContext : DbContext
    {
        public PTWiseDbContext(DbContextOptions<PTWiseDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Trainers
            modelBuilder.Entity<Trainer>().HasData(new Trainer
            {
                Id = 1,
                Title = "Mr",
                FirstName = "John",
                LastName = "Palmer",
                DateOfBirth = new DateTime(1970, 10, 11),
                EmailAddress = "johnpalmer@ptwise.com",
                GymName = "PT Wise Gym",
                TelephoneNumber = "1234567890",
                Address = new Address 
                {
                    AddressLine1 = "5 Geraldine Road",
                    Country = "United Kingdom",
                    Postcode = "WR14 3SZ"
                }
            });
            modelBuilder.Entity<Trainer>().HasData(new Trainer
            {
                Id = 2,
                Title = "Mr",
                FirstName = "Ben",
                LastName = "Chadwick",
                DateOfBirth = new DateTime(2002, 10, 30),
                EmailAddress = "benchadwick@ptwise.com",
                GymName = "PT Wise Gym",
                TelephoneNumber = "07496327386",
                Address = new Address
                {
                    AddressLine1 = "20 Burnout Close",
                    Country = "United Kingdom",
                    Postcode = "WR14 1KT"
                }
            });

            //Clients
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 1,
                Title = "Mr",
                FirstName = "Kacper",
                LastName = "Marciniak",
                DateOfBirth = new DateTime(2003, 01, 06),
                EmailAddress = "kacermarciniak@gmail.com",
                TelephoneNumber = "07465321286",
                Address = new Address
                {
                    AddressLine1 = "100 Elgar Road",
                    Country = "United Kingdom",
                    Postcode = "WR14 3EZ"
                },

            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 2,
                Title = "Ms",
                FirstName = "Emily",
                LastName = "Johnson",
                DateOfBirth = new DateTime(1995, 03, 15),
                EmailAddress = "emily.johnson@example.com",
                TelephoneNumber = "07894561234",
                Address = new Address
                {
                    AddressLine1 = "25 Oak Street",
                    Country = "United Kingdom",
                    Postcode = "AB12 3CD"
                }

            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 3,
                Title = "Mrs",
                FirstName = "Sophia",
                LastName = "Garcia",
                DateOfBirth = new DateTime(1988, 07, 22),
                EmailAddress = "sophia.garcia@example.com",
                TelephoneNumber = "07123456789",
                Address = new Address
                {
                    AddressLine1 = "15 Maple Avenue",
                    Country = "United Kingdom",
                    Postcode = "XY34 9AB"
                }

            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 4,
                Title = "Mr",
                FirstName = "Daniel",
                LastName = "Smith",
                DateOfBirth = new DateTime(1990, 11, 03),
                EmailAddress = "daniel.smith@example.com",
                TelephoneNumber = "07654321098",
                Address = new Address
                {
                    AddressLine1 = "7 Pine Street",
                    Country = "United Kingdom",
                    Postcode = "CD56 8EF"
                }

            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 5,
                Title = "Miss",
                FirstName = "Isabella",
                LastName = "Brown",
                DateOfBirth = new DateTime(2001, 05, 20),
                EmailAddress = "isabella.brown@example.com",
                TelephoneNumber = "07987654321",
                Address = new Address
                {
                    AddressLine1 = "30 Elm Road",
                    Country = "United Kingdom",
                    Postcode = "EF67 2GH"
                }

            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 6,
                Title = "Mr",
                FirstName = "Oliver",
                LastName = "Davis",
                DateOfBirth = new DateTime(1985, 12, 10),
                EmailAddress = "oliver.davis@example.com",
                TelephoneNumber = "07234567890",
                Address = new Address
                {
                    AddressLine1 = "12 Birch Lane",
                    Country = "United Kingdom",
                    Postcode = "GH45 1IJ"
                }
            });

            //Appointments
            modelBuilder.Entity<Appointment>().HasData(new Appointment
            {
                Id = 1,
                Date = new DateTime(2023, 11, 28, 12, 30, 0),
                Status = Status.Completed,
                ClientId = 6,
                TrainerId = 1,
            });
            modelBuilder.Entity<Appointment>().HasData(new Appointment
            {
                Id = 2,
                Date = new DateTime(2023, 11, 28, 15, 0, 0),
                Status = Status.Completed,
                ClientId = 5,
                TrainerId = 1,
            });
            modelBuilder.Entity<Appointment>().HasData(new Appointment
            {
                Id = 3,
                Date = new DateTime(2023, 11, 30, 9, 0, 0),
                Status = Status.Scheduled,
                ClientId = 4,
                TrainerId = 1,
            });
            modelBuilder.Entity<Appointment>().HasData(new Appointment
            {
                Id = 4,
                Date = new DateTime(2023, 12, 5, 10, 30, 0),
                Status = Status.Scheduled,
                ClientId = 2,
                TrainerId = 2,
            });

            //Payments
            modelBuilder.Entity<Payment>().HasData(new Payment
            {
                Id = 1,
                Date = new DateTime(2023, 12, 5, 10, 30, 0),
                Amount = 80,
                ClientId= 1,
            });
        }
    }
}
