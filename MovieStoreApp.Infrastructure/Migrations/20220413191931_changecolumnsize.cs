using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieStoreApp.Infrastructure.Migrations
{
    public partial class changecolumnsize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TmdbUrl",
                table: "Movie",
                type: "Varchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Tagline",
                table: "Movie",
                type: "Varchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "PosterUrl",
                table: "Movie",
                type: "Varchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "ImdbUrl",
                table: "Movie",
                type: "Varchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "BackdropUrl",
                table: "Movie",
                type: "Varchar(350)",
                maxLength: 350,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(150)",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TmdbUrl",
                table: "Movie",
                type: "Varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "Tagline",
                table: "Movie",
                type: "Varchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "PosterUrl",
                table: "Movie",
                type: "Varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "ImdbUrl",
                table: "Movie",
                type: "Varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(350)",
                oldMaxLength: 350);

            migrationBuilder.AlterColumn<string>(
                name: "BackdropUrl",
                table: "Movie",
                type: "Varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(350)",
                oldMaxLength: 350);
        }
    }
}
