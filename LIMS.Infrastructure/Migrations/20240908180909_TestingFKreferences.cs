using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LIMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TestingFKreferences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_CalibrationRecords_CalibrationRecordId",
                table: "Instruments");

            migrationBuilder.DropIndex(
                name: "IX_Instruments_CalibrationRecordId",
                table: "Instruments");

            migrationBuilder.DropColumn(
                name: "CalibrationRecordId",
                table: "Instruments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalibrationRecordId",
                table: "Instruments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_CalibrationRecordId",
                table: "Instruments",
                column: "CalibrationRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_CalibrationRecords_CalibrationRecordId",
                table: "Instruments",
                column: "CalibrationRecordId",
                principalTable: "CalibrationRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
