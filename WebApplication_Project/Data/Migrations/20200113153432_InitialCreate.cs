using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Project.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


           

            migrationBuilder.CreateTable(
                name: "gSGames",
                columns: table => new
                {
                    game_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 33, nullable: true),
                    genre = table.Column<string>(maxLength: 53, nullable: true),
                    price = table.Column<int>(nullable: false),
                    age_limit = table.Column<int>(nullable: false),
                    release_data = table.Column<string>(maxLength: 20, nullable: true),
                    description = table.Column<string>(maxLength: 763, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gSGames", x => x.game_id);
                });

            migrationBuilder.CreateTable(
                name: "gSUsers",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 20, nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: true),
                    username = table.Column<string>(maxLength: 20, nullable: true),
                    password = table.Column<string>(maxLength: 20, nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    gender = table.Column<string>(maxLength: 20, nullable: true),
                    age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gSUsers", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "gSOrders",
                columns: table => new
                {
                    order_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gamesgame_id = table.Column<int>(nullable: true),
                    Usersuser_id = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gSOrders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_gSOrders_gSGames_Gamesgame_id",
                        column: x => x.Gamesgame_id,
                        principalTable: "gSGames",
                        principalColumn: "game_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_gSOrders_gSUsers_Usersuser_id",
                        column: x => x.Usersuser_id,
                        principalTable: "gSUsers",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_gSOrders_Gamesgame_id",
                table: "gSOrders",
                column: "Gamesgame_id");

            migrationBuilder.CreateIndex(
                name: "IX_gSOrders_Usersuser_id",
                table: "gSOrders",
                column: "Usersuser_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gSOrders");

            migrationBuilder.DropTable(
                name: "gSGames");

            migrationBuilder.DropTable(
                name: "gSUsers");

           
        }
    }
}
