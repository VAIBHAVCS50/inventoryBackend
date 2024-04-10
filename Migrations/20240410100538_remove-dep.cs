using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inventBackend.Migrations
{
    /// <inheritdoc />
    public partial class removedep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
