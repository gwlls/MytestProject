using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstAbpCore.Migrations
{
    public partial class addNewFieldsToTb_NoteBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Tb_NoteBook",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpuPara",
                table: "Tb_NoteBook",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StorageSize",
                table: "Tb_NoteBook",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Tb_NoteBook",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Tb_NoteBook");

            migrationBuilder.DropColumn(
                name: "CpuPara",
                table: "Tb_NoteBook");

            migrationBuilder.DropColumn(
                name: "StorageSize",
                table: "Tb_NoteBook");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Tb_NoteBook");
        }
    }
}
