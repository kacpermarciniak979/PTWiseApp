﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PTWiseApp.API.Data;

#nullable disable

namespace PTWiseApp.API.Migrations
{
    [DbContext(typeof(PTWiseDbContext))]
    partial class PTWiseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PTWiseApp.API.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.Property<int?>("TrainerId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ClientId1");

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainerId1");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 6,
                            Date = new DateTime(2023, 11, 28, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 2,
                            ClientId = 5,
                            Date = new DateTime(2023, 11, 28, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 3,
                            ClientId = 4,
                            Date = new DateTime(2023, 11, 30, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 4,
                            ClientId = 2,
                            Date = new DateTime(2023, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TrainerId = 2
                        });
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "100 Elgar Road",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(2003, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "kacermarciniak@gmail.com",
                            FirstName = "Kacper",
                            LastName = "Marciniak",
                            Postcode = "WR14 3EZ",
                            TelephoneNumber = "07465321286",
                            Title = "Mr",
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "25 Oak Street",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "emily.johnson@example.com",
                            FirstName = "Emily",
                            LastName = "Johnson",
                            Postcode = "AB12 3CD",
                            TelephoneNumber = "07894561234",
                            Title = "Ms",
                            TrainerId = 2
                        },
                        new
                        {
                            Id = 3,
                            AddressLine1 = "15 Maple Avenue",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(1988, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "sophia.garcia@example.com",
                            FirstName = "Sophia",
                            LastName = "Garcia",
                            Postcode = "XY34 9AB",
                            TelephoneNumber = "07123456789",
                            Title = "Mrs",
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 4,
                            AddressLine1 = "7 Pine Street",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(1990, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "daniel.smith@example.com",
                            FirstName = "Daniel",
                            LastName = "Smith",
                            Postcode = "CD56 8EF",
                            TelephoneNumber = "07654321098",
                            Title = "Mr",
                            TrainerId = 2
                        },
                        new
                        {
                            Id = 5,
                            AddressLine1 = "30 Elm Road",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(2001, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "isabella.brown@example.com",
                            FirstName = "Isabella",
                            LastName = "Brown",
                            Postcode = "EF67 2GH",
                            TelephoneNumber = "07987654321",
                            Title = "Miss",
                            TrainerId = 1
                        },
                        new
                        {
                            Id = 6,
                            AddressLine1 = "12 Birch Lane",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(1985, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "oliver.davis@example.com",
                            FirstName = "Oliver",
                            LastName = "Davis",
                            Postcode = "GH45 1IJ",
                            TelephoneNumber = "07234567890",
                            Title = "Mr",
                            TrainerId = 2
                        });
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestPeriod")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Difficulty = 0,
                            ExerciseType = 2,
                            Name = "Bench Press",
                            Reps = "6",
                            RestPeriod = 90,
                            Sets = 4,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 2,
                            Difficulty = 0,
                            ExerciseType = 2,
                            Name = "Tricep Extensions",
                            Reps = "8",
                            RestPeriod = 60,
                            Sets = 5,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 3,
                            Difficulty = 1,
                            ExerciseType = 2,
                            Name = "Squat",
                            Reps = "8",
                            RestPeriod = 120,
                            Sets = 4,
                            WorkoutId = 2
                        },
                        new
                        {
                            Id = 4,
                            Difficulty = 2,
                            ExerciseType = 2,
                            Name = "Deadlift",
                            Reps = "6",
                            RestPeriod = 120,
                            Sets = 4,
                            WorkoutId = 2
                        },
                        new
                        {
                            Id = 5,
                            Difficulty = 1,
                            ExerciseType = 2,
                            Name = "Pull-ups",
                            Reps = "10",
                            RestPeriod = 60,
                            Sets = 3,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 6,
                            Difficulty = 1,
                            ExerciseType = 2,
                            Name = "Shoulder Press",
                            Reps = "8",
                            RestPeriod = 90,
                            Sets = 4,
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 7,
                            Difficulty = 0,
                            ExerciseType = 2,
                            Name = "Bicep Curls",
                            Reps = "10",
                            RestPeriod = 45,
                            Sets = 3,
                            WorkoutId = 2
                        },
                        new
                        {
                            Id = 8,
                            Difficulty = 1,
                            ExerciseType = 2,
                            Name = "Lunges",
                            Reps = "12",
                            RestPeriod = 60,
                            Sets = 3,
                            WorkoutId = 1
                        });
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 80,
                            ClientId = 1,
                            Date = new DateTime(2023, 12, 5, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GymName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressLine1 = "5 Geraldine Road",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(1970, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "johnpalmer@ptwise.com",
                            FirstName = "John",
                            GymName = "PT Wise Gym",
                            LastName = "Palmer",
                            Postcode = "WR14 3SZ",
                            TelephoneNumber = "1234567890",
                            Title = "Mr"
                        },
                        new
                        {
                            Id = 2,
                            AddressLine1 = "20 Burnout Close",
                            Country = "United Kingdom",
                            DateOfBirth = new DateTime(2002, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "benchadwick@ptwise.com",
                            FirstName = "Ben",
                            GymName = "PT Wise Gym",
                            LastName = "Chadwick",
                            Postcode = "WR14 1KT",
                            TelephoneNumber = "07496327386",
                            Title = "Mr"
                        });
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationMins")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppointmentId = 1,
                            Date = new DateTime(2023, 11, 30, 15, 59, 2, 103, DateTimeKind.Local).AddTicks(8690),
                            DurationMins = 60,
                            Name = "Bombaclaat Belly Blast"
                        },
                        new
                        {
                            Id = 2,
                            AppointmentId = 2,
                            Date = new DateTime(2023, 11, 30, 15, 59, 2, 103, DateTimeKind.Local).AddTicks(8746),
                            DurationMins = 60,
                            Name = "Marcin's Muscle Maker"
                        });
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Appointment", b =>
                {
                    b.HasOne("PTWiseApp.API.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PTWiseApp.API.Entities.Client", null)
                        .WithMany("Appointments")
                        .HasForeignKey("ClientId1");

                    b.HasOne("PTWiseApp.API.Entities.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PTWiseApp.API.Entities.Trainer", null)
                        .WithMany("Appointments")
                        .HasForeignKey("TrainerId1");

                    b.Navigation("Client");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Client", b =>
                {
                    b.HasOne("PTWiseApp.API.Entities.Trainer", "Trainer")
                        .WithMany("Clients")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Exercise", b =>
                {
                    b.HasOne("PTWiseApp.API.Entities.Workout", "Workout")
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Payment", b =>
                {
                    b.HasOne("PTWiseApp.API.Entities.Client", "Client")
                        .WithMany("Payments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Workout", b =>
                {
                    b.HasOne("PTWiseApp.API.Entities.Appointment", "Appointment")
                        .WithMany("Workouts")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Appointment", b =>
                {
                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Client", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Trainer", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("PTWiseApp.API.Entities.Workout", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
