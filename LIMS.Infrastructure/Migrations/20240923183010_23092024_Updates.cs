using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LIMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _23092024_Updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalibrationRecords_Technicians_TechnicianId",
                table: "CalibrationRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Instruments_InstrumentId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_InstrumentId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_CalibrationRecords_TechnicianId",
                table: "CalibrationRecords");

            migrationBuilder.RenameColumn(
                name: "CalibrationDueDate",
                table: "CalibrationRecords",
                newName: "TechnicianName");

            migrationBuilder.RenameColumn(
                name: "CalibrationDate",
                table: "CalibrationRecords",
                newName: "NextCalibrationDueDate");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Technicians",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaboratoryId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "OrderDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CalibrationRecordId",
                table: "Instruments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CurrentCalibrationDate",
                table: "Instruments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CurrentCalibrationDate",
                table: "CalibrationRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "LaboratoryId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CalibrationRecordId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "CurrentCalibrationDate",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "CurrentCalibrationDate",
                table: "CalibrationRecords");

            migrationBuilder.RenameColumn(
                name: "TechnicianName",
                table: "CalibrationRecords",
                newName: "CalibrationDueDate");

            migrationBuilder.RenameColumn(
                name: "NextCalibrationDueDate",
                table: "CalibrationRecords",
                newName: "CalibrationDate");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_InstrumentId",
                table: "OrderDetails",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CalibrationRecords_TechnicianId",
                table: "CalibrationRecords",
                column: "TechnicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalibrationRecords_Technicians_TechnicianId",
                table: "CalibrationRecords",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Instruments_InstrumentId",
                table: "OrderDetails",
                column: "InstrumentId",
                principalTable: "Instruments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
