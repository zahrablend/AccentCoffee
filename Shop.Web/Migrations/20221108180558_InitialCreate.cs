using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockCoffee = table.Column<int>(type: "int", nullable: false),
                    StockWater = table.Column<int>(type: "int", nullable: false),
                    StockMilk = table.Column<int>(type: "int", nullable: false),
                    StockIceCream = table.Column<int>(type: "int", nullable: false),
                    StockChocolate = table.Column<int>(type: "int", nullable: false),
                    StockSugar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
