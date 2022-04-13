using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStoreApp.Infrastructure.Migrations
{
    public partial class changetitletype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cast",
                type: "Varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(30)",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cast",
                type: "Varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldMaxLength: 100);
        }
    }
}
