using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab2_abi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: true),
                    EstimationCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeveloperTicket",
                columns: table => new
                {
                    DevelopersId = table.Column<int>(type: "int", nullable: false),
                    TicketsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperTicket", x => new { x.DevelopersId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_DeveloperTicket_Developers_DevelopersId",
                        column: x => x.DevelopersId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeveloperTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Automotive & Baby" },
                    { 2, "Beauty & Health" },
                    { 3, "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Freddie" },
                    { 2, "Sophia" },
                    { 3, "Angela" },
                    { 4, "Jamie" },
                    { 5, "Geoffrey" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[,]
                {
                    { 1, 2, "Rerum totam est quo possimus sunt sunt ad.", 400m, 0 },
                    { 2, 3, "Id cumque explicabo beatae.", 200m, 1 },
                    { 3, 3, "Consectetur beatae dolorem voluptates occaecati.", 300m, 0 },
                    { 4, 3, "Nulla est doloribus ut non aspernatur vero dolores.", 200m, 2 },
                    { 5, 2, "Et praesentium est ipsum eligendi rerum itaque voluptate quia.", 200m, 1 },
                    { 6, 3, "Optio non debitis ut molestiae dolorem ad.", 100m, 2 },
                    { 7, 1, "Dolor quae iure quas error est.", 200m, 2 },
                    { 8, 2, "Iste molestiae aut inventore necessitatibus necessitatibus perspiciatis sit.", 200m, 2 },
                    { 9, 2, "Voluptas expedita placeat ad sint consequuntur.", 200m, 0 },
                    { 10, 1, "Voluptates qui sed aliquid laudantium in.", 200m, 0 },
                    { 11, 3, "Placeat non repellat qui libero.", 200m, 1 },
                    { 12, 3, "Debitis vero laborum asperiores deserunt nihil tempora quia.", 200m, 2 },
                    { 13, 1, "Voluptatibus a et natus ipsa at quis rem dolores.", 500m, 0 },
                    { 14, 1, "Dolorem qui animi sint ad facere ut ullam voluptatem repellendus.", 200m, 1 },
                    { 15, 2, "Sint suscipit delectus accusamus distinctio earum aliquam.", 200m, 2 },
                    { 16, 2, "Et vel tempora.", 200m, 0 },
                    { 17, 2, "Aut atque officiis numquam mollitia voluptas dolore.", 200m, 1 },
                    { 18, 3, "Ipsum mollitia sit officiis sapiente natus.", 300m, 2 },
                    { 19, 1, "Inventore aut reprehenderit vitae ratione dolorum harum.", 400m, 2 },
                    { 20, 1, "Harum hic impedit dolore voluptate placeat.", 200m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperTicket_TicketsId",
                table: "DeveloperTicket",
                column: "TicketsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DepartmentId",
                table: "Tickets",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeveloperTicket");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
