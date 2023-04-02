using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab2_abi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Diabetes");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Hypertension");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Asthma");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Depression" },
                    { 5, "Arthritis" },
                    { 6, "Allergy" },
                    { 7, "Flu" }
                });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Dana");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Isaac");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Damon");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Miriam");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Terence");

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Roosevelt" },
                    { 7, "Eduardo" },
                    { 8, "Wilbert" },
                    { 9, "Tasha" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "EstimationCost" },
                values: new object[] { 1, "Jessie", 27064m });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 2, "Jessie", 27064m, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EstimationCost", "Severity" },
                values: new object[] { "Jessie", 27064m, 1 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 5, "Jessie", 27064m, 1 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 6, "Jessie", 27064m, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 5, "Jessie", 27064m, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 2, "Jessie", 27064m, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EstimationCost" },
                values: new object[] { "Jessie", 27064m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Automotive & Baby");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Beauty & Health");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Freddie");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sophia");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Angela");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Jamie");

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Geoffrey");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Description", "EstimationCost" },
                values: new object[] { 2, "Rerum totam est quo possimus sunt sunt ad.", 400m });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 3, "Id cumque explicabo beatae.", 200m, 1 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EstimationCost", "Severity" },
                values: new object[] { "Consectetur beatae dolorem voluptates occaecati.", 300m, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 3, "Nulla est doloribus ut non aspernatur vero dolores.", 200m, 2 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 2, "Et praesentium est ipsum eligendi rerum itaque voluptate quia.", 200m, 1 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 3, "Optio non debitis ut molestiae dolorem ad.", 100m, 2 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[] { 1, "Dolor quae iure quas error est.", 200m, 2 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "EstimationCost" },
                values: new object[] { "Voluptates qui sed aliquid laudantium in.", 200m });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "DepartmentId", "Description", "EstimationCost", "Severity" },
                values: new object[,]
                {
                    { 8, 2, "Iste molestiae aut inventore necessitatibus necessitatibus perspiciatis sit.", 200m, 2 },
                    { 9, 2, "Voluptas expedita placeat ad sint consequuntur.", 200m, 0 },
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
        }
    }
}
