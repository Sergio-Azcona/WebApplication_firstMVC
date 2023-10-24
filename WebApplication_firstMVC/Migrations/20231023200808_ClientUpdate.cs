using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_firstMVC.Migrations
{
    /// <inheritdoc />
    public partial class ClientUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "Client");
        }
    }
}
