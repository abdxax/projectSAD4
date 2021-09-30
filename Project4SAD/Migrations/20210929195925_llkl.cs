using Microsoft.EntityFrameworkCore.Migrations;

namespace Project4SAD.Migrations
{
    public partial class llkl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_customerOrders_customerOrderId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_pizzas_PizzaId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_customerOrderId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_PizzaId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "customerOrderId",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "Pizza",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "customerOrder",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pizza",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "customerOrder",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerOrderId",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_orders_customerOrderId",
                table: "orders",
                column: "customerOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_PizzaId",
                table: "orders",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customerOrders_customerOrderId",
                table: "orders",
                column: "customerOrderId",
                principalTable: "customerOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_pizzas_PizzaId",
                table: "orders",
                column: "PizzaId",
                principalTable: "pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
