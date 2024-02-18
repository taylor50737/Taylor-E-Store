using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Companies");
        }
    }
}
