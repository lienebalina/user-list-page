using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_list_page.Migrations
{
    /// <inheritdoc />
    public partial class AddSpouseToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Spouse",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spouse",
                table: "Users");
        }
    }
}
