using Microsoft.EntityFrameworkCore.Migrations;

namespace BonTemps.Migrations
{
    public partial class ChangeDishCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Dish_DishRef",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_DishRef",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DishRef",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "CategoryRef",
                table: "Dish",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_CategoryRef",
                table: "Dish",
                column: "CategoryRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Category_CategoryRef",
                table: "Dish",
                column: "CategoryRef",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Category_CategoryRef",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_CategoryRef",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "CategoryRef",
                table: "Dish");

            migrationBuilder.AddColumn<int>(
                name: "DishRef",
                table: "Category",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Category_DishRef",
                table: "Category",
                column: "DishRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Dish_DishRef",
                table: "Category",
                column: "DishRef",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
