using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstAbpCore.Migrations
{
    public partial class addNewFieldToTb_NoteBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Tb_NoteBook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Tb_NoteBook");
        }
    }
}
