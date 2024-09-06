using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LIMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLaboratoryInstrumentRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Laboratories_LaboratoryId",
                table: "Instruments");

            migrationBuilder.AlterColumn<int>(
                name: "LaboratoryId",
                table: "Instruments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Laboratories_LaboratoryId",
                table: "Instruments",
                column: "LaboratoryId",
                principalTable: "Laboratories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instruments_Laboratories_LaboratoryId",
                table: "Instruments");

            migrationBuilder.AlterColumn<int>(
                name: "LaboratoryId",
                table: "Instruments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Instruments_Laboratories_LaboratoryId",
                table: "Instruments",
                column: "LaboratoryId",
                principalTable: "Laboratories",
                principalColumn: "Id");
        }
    }
}
