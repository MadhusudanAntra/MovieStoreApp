using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStoreApp.Infrastructure.Migrations
{
    public partial class changepricenullable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Overview",
                table: "Movie",
                type: "Varchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(500)",
                oldMaxLength: 500);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Overview",
                table: "Movie",
                type: "Varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(1000)",
                oldMaxLength: 1000);
        }
    }
}
