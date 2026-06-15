using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class addingTechnologiesUsedToProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "aboutMe",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "education",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "technologiesUsed",
                table: "project",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "technologiesUsed",
                table: "project");

            migrationBuilder.InsertData(
                table: "aboutMe",
                columns: new[] { "ID", "description", "firstName", "greeting", "lastName" },
                values: new object[] { 1, "I'm a university student, currently pursuing my degree in Computer Engineering. My coding journey started with C++, and I spent a long time building projects with it. From there, I expanded into C#, MS SQL, Python, and other technologies. Lately, I've been diving into web technologies, and I'm excited to start my career as a Full Stack Developer. But don't think my life is all about writing code. I love cycling  — I usually join group rides — and I really enjoy playing table tennis  and meeting new people. So don't hesitate to reach out. I'd love to connect with you!", "ibrahim", "Hi There!", "agrud" });

            migrationBuilder.InsertData(
                table: "education",
                columns: new[] { "Id", "endYear", "entranceYear", "imgPath", "schoolTitle", "schoolType" },
                values: new object[] { 1, new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "img", "Selcuk", "college" });
        }
    }
}
