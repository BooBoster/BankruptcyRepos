using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankruptcyTask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Arbitrator20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArbitratorId",
                table: "Debtors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Debtors_ArbitratorId",
                table: "Debtors",
                column: "ArbitratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Debtors_Arbitrators_ArbitratorId",
                table: "Debtors",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Debtors_Arbitrators_ArbitratorId",
                table: "Debtors");

            migrationBuilder.DropIndex(
                name: "IX_Debtors_ArbitratorId",
                table: "Debtors");

            migrationBuilder.DropColumn(
                name: "ArbitratorId",
                table: "Debtors");
        }
    }
}
