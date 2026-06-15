using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class AddEducation1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schoolTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schoolType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    entranceYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    imgPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "education",
                columns: new[] { "Id", "endYear", "entranceYear", "imgPath", "schoolTitle", "schoolType" },
                values: new object[] { 1, new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img", "Selcuk", "college" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "education");
        }
    }
}
