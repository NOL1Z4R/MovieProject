using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieProject.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Movie_MoviesId",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Rates_MoviesId",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Rates");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Rates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_MovieId",
                table: "Rates",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Movies_MovieId",
                table: "Rates",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Movies_MovieId",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Rates_MovieId",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Rates");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "Rates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_MoviesId",
                table: "Rates",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Movie_MoviesId",
                table: "Rates",
                column: "MoviesId",
                principalTable: "Movie",
                principalColumn: "Id");
        }
    }
}
