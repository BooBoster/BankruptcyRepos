using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankruptcyTask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EntityFix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Estates",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Debtors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Debtors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ArbitratorId",
                table: "Debtors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Debtors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Arbitrators",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Arbitrators",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Debtors_ArbitratorId",
                table: "Debtors",
                column: "ArbitratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Debtors_Arbitrators_ArbitratorId",
                table: "Debtors",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id");
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

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Debtors");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Debtors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Debtors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Arbitrators",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Arbitrators",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
