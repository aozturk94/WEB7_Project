using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bus_Ticket_Booking.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusSeats",
                columns: table => new
                {
                    BusSeatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusSeatCheckhed = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusSeats", x => x.BusSeatId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartLocation = table.Column<string>(type: "TEXT", nullable: true),
                    FirstRoute = table.Column<string>(type: "TEXT", nullable: true),
                    SecondRoute = table.Column<string>(type: "TEXT", nullable: true),
                    ThirdRoute = table.Column<string>(type: "TEXT", nullable: true),
                    EndLocation = table.Column<string>(type: "TEXT", nullable: true),
                    DepartureDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Time = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PassengerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    PassengerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    PassengerMail = table.Column<string>(type: "TEXT", nullable: true),
                    TravelFrom = table.Column<string>(type: "TEXT", nullable: true),
                    TravelTo = table.Column<string>(type: "TEXT", nullable: true),
                    DepartureDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    BusSeatId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketPrice = table.Column<double>(type: "REAL", nullable: false),
                    RouteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RouteId",
                table: "Tickets",
                column: "RouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusSeats");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
