using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace equb.Migrations
{
    public partial class cretaingtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    cust_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    f_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    l_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    contact = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.cust_id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    balance = table.Column<float>(type: "real", nullable: false),
                    cust_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.account_id);
                    table.ForeignKey(
                        name: "FK_Account_Customer_cust_id",
                        column: x => x.cust_id,
                        principalTable: "Customer",
                        principalColumn: "cust_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equb_detail",
                columns: table => new
                {
                    equb_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    equb_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number_of_users = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<float>(type: "real", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cust_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equb_detail", x => x.equb_id);
                    table.ForeignKey(
                        name: "FK_Equb_detail_Customer_cust_id",
                        column: x => x.cust_id,
                        principalTable: "Customer",
                        principalColumn: "cust_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transact",
                columns: table => new
                {
                    trans_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<float>(type: "real", nullable: false),
                    trans_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trans_to = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cust_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transact", x => x.trans_id);
                    table.ForeignKey(
                        name: "FK_Transact_Customer_cust_id",
                        column: x => x.cust_id,
                        principalTable: "Customer",
                        principalColumn: "cust_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equb_order",
                columns: table => new
                {
                    equb_order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cust_id = table.Column<int>(type: "int", nullable: true),
                    equb_id = table.Column<int>(type: "int", nullable: true),
                    order = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    win_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equb_order", x => x.equb_order_id);
                    table.ForeignKey(
                        name: "FK_Equb_order_Customer_cust_id",
                        column: x => x.cust_id,
                        principalTable: "Customer",
                        principalColumn: "cust_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equb_order_Equb_detail_equb_id",
                        column: x => x.equb_id,
                        principalTable: "Equb_detail",
                        principalColumn: "equb_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    reserve_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cust_id = table.Column<int>(type: "int", nullable: true),
                    equb_id = table.Column<int>(type: "int", nullable: true),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.reserve_id);
                    table.ForeignKey(
                        name: "FK_Reserves_Customer_cust_id",
                        column: x => x.cust_id,
                        principalTable: "Customer",
                        principalColumn: "cust_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reserves_Equb_detail_equb_id",
                        column: x => x.equb_id,
                        principalTable: "Equb_detail",
                        principalColumn: "equb_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_cust_id",
                table: "Account",
                column: "cust_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equb_detail_cust_id",
                table: "Equb_detail",
                column: "cust_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equb_order_cust_id",
                table: "Equb_order",
                column: "cust_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equb_order_equb_id",
                table: "Equb_order",
                column: "equb_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reserves_cust_id",
                table: "Reserves",
                column: "cust_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reserves_equb_id",
                table: "Reserves",
                column: "equb_id");

            migrationBuilder.CreateIndex(
                name: "IX_Transact_cust_id",
                table: "Transact",
                column: "cust_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Equb_order");

            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "Transact");

            migrationBuilder.DropTable(
                name: "Equb_detail");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
