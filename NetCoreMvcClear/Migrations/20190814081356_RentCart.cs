using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreMvcClear.Migrations
{
    public partial class RentCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentItemId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    RentCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentCartItems_RentItems_RentItemId",
                        column: x => x.RentItemId,
                        principalTable: "RentItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentCartItems_RentItemId",
                table: "RentCartItems",
                column: "RentItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentCartItems");
        }
    }
}
