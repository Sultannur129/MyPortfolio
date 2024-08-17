using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class newColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name:"ImgUrl",
                table:"Experiences",
                nullable: true);
            migrationBuilder.AddColumn<string>(
               name: "ProjectUrl",
               table: "Experiences",
               nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
