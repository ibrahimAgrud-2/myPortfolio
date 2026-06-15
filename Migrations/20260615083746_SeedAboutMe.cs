using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class SeedAboutMe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "aboutMe",
                columns: new[] { "ID", "description", "firstName", "greeting", "lastName" },
                values: new object[] { 1, "I'm a university student, currently pursuing my degree in Computer\r\n                        I'm a university student, currently pursuing my degree in Computer Engineering.\r\n                        My coding journey started with C++, and I spent a long time building projects with it. From\r\n                        there, I expanded into C#, MS SQL, Python, and other technologies.  Lately, I've been diving\r\n                        into web technologies , and I'm excited to start my career as a Full Stack Developer.\r\n                        But don't think my life is all about writing code \r\n                        I love cycling  — I usually join group rides — and I really enjoy playing table tennis  and\r\n                        meeting new people . So don't hesitate to reach out. I'd love to connect with you! ", "ibrahim", "Hi There!", "agrud" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "aboutMe",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
