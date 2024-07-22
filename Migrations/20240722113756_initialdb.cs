using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLiteEF_LoRa.Migrations
{
    /// <inheritdoc />
    public partial class initialdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbLoRaComm",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Frequency = table.Column<double>(type: "REAL", nullable: false),
                    DataRate = table.Column<string>(type: "TEXT", nullable: false),
                    SNR = table.Column<double>(type: "REAL", nullable: false),
                    RSSI = table.Column<int>(type: "INTEGER", nullable: false),
                    Payload = table.Column<string>(type: "TEXT", nullable: false),
                    DeviceAddress = table.Column<string>(type: "TEXT", nullable: false),
                    FrameCounter = table.Column<uint>(type: "INTEGER", nullable: false),
                    Port = table.Column<byte>(type: "INTEGER", nullable: false),
                    CRCStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    MessageLength = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLoRaComm", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbLoRaComm");
        }
    }
}
