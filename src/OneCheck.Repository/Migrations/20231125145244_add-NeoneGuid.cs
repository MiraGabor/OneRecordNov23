using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneCheck.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addNeoneGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NeoneGuid",
                table: "correspondenceULDShipmentModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NeoneGuid",
                table: "correspondenceULDShipmentModel");
        }
    }
}
