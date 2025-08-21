using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreRazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class cls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department1Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee1_Department1_Department1Id",
                        column: x => x.Department1Id,
                        principalTable: "Department1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee1_Department1Id",
                table: "Employee1",
                column: "Department1Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee1");

            migrationBuilder.DropTable(
                name: "Department1");
        }
    }
}
