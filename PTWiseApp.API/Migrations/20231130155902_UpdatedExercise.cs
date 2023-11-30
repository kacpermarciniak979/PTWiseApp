using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PTWiseApp.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Workouts_WorkoutId",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutId",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "AppointmentId", "Date", "DurationMins", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 30, 15, 59, 2, 103, DateTimeKind.Local).AddTicks(8690), 60, "Bombaclaat Belly Blast" },
                    { 2, 2, new DateTime(2023, 11, 30, 15, 59, 2, 103, DateTimeKind.Local).AddTicks(8746), 60, "Marcin's Muscle Maker" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Difficulty", "ExerciseType", "Name", "Reps", "RestPeriodSeconds", "Sets", "WorkoutId" },
                values: new object[,]
                {
                    { 1, 0, 2, "Bench Press", "6", 90, 4, 1 },
                    { 2, 0, 2, "Tricep Extensions", "8", 60, 5, 1 },
                    { 3, 1, 2, "Squat", "8", 120, 4, 2 },
                    { 4, 2, 2, "Deadlift", "6", 120, 4, 2 },
                    { 5, 1, 2, "Pull-ups", "10", 60, 3, 1 },
                    { 6, 1, 2, "Shoulder Press", "8", 90, 4, 1 },
                    { 7, 0, 2, "Bicep Curls", "10", 45, 3, 2 },
                    { 8, 1, 2, "Lunges", "12", 60, 3, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Workouts_WorkoutId",
                table: "Exercises",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Workouts_WorkoutId",
                table: "Exercises");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutId",
                table: "Exercises",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Workouts_WorkoutId",
                table: "Exercises",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }
    }
}
