using Microsoft.EntityFrameworkCore.Migrations;

namespace BonTemps.Migrations
{
    public partial class ChangeDishCategoryRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Dish_DishId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_DishId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Category");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "DishId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_DishId",
                table: "Category",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Dish_DishId",
                table: "Category",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
