using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreMvcClear.Migrations
{
    public partial class UpdateRentCartAndOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<long>(
                name: "Quantity",
                table: "RentCartItems",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Quantity",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<long>(
                name: "ItemPrice",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "RentCartItems",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "Amount",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
