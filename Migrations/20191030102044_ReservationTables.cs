using Microsoft.EntityFrameworkCore.Migrations;

namespace BonTemps.Migrations
{
    public partial class ReservationTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Reservation_ReservationId",
                table: "Table");

            migrationBuilder.DropIndex(
                name: "IX_Table_ReservationId",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Table");

            migrationBuilder.CreateTable(
                name: "ReservationTable",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false),
                    TableId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTable", x => new { x.ReservationId, x.TableId });
                    table.ForeignKey(
                        name: "FK_ReservationTable_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationTable_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationTable_TableId",
                table: "ReservationTable",
                column: "TableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationTable");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Table",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Table_ReservationId",
                table: "Table",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Reservation_ReservationId",
                table: "Table",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
