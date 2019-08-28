using Microsoft.EntityFrameworkCore.Migrations;

namespace AmazingMicroStore.Infra.DataAccess.Migrations
{
    public partial class removed_description_from_catalogproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogProducts",
                nullable: true);
        }
    }
}
