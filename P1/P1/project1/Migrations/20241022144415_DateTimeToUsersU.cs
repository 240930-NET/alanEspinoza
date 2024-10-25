using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project1.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeToUsersU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateUserCreated",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "LastestDateUserLogin",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "LatestTimeUserLogin",
                table: "Users",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TimeUserCreated",
                table: "Users",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUserCreated",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastestDateUserLogin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LatestTimeUserLogin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TimeUserCreated",
                table: "Users");
        }
    }
}
