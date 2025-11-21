using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE.TRAINING.WITH.AI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookDeposit");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Deposits",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Deposits_BookId",
                table: "Deposits",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Books_BookId",
                table: "Deposits",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.UpdateData(
               table: "Deposits",
                keyColumns: new[] { "Id" },
                keyValues: new object[] { 5 }, 
                columns: new[] { "BookId" },   
                values: new object[] { 14 }
                );
            migrationBuilder.UpdateData(
               table: "Deposits",
                keyColumns: new[] { "Id" },
                keyValues: new object[] { 6 }, 
                columns: new[] { "BookId" },  
                values: new object[] { 15 }
                );
            migrationBuilder.UpdateData(
               table: "Deposits",
                keyColumns: new[] { "Id" },
                keyValues: new object[] { 7 },
                columns: new[] { "BookId" },  
                values: new object[] { 13 }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_Books_BookId",
                table: "Deposits");

            migrationBuilder.DropIndex(
                name: "IX_Deposits_BookId",
                table: "Deposits");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Deposits");

            migrationBuilder.CreateTable(
                name: "BookDeposit",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    DepositId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDeposit", x => new { x.BooksId, x.DepositId });
                    table.ForeignKey(
                        name: "FK_BookDeposit_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookDeposit_Deposits_DepositId",
                        column: x => x.DepositId,
                        principalTable: "Deposits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookDeposit_DepositId",
                table: "BookDeposit",
                column: "DepositId");
        }
    }
}
