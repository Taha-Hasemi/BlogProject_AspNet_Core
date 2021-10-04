using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Add_WriterID_in_Blog_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Writers_WriterID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_WriterID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Comments");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WriterID",
                table: "Comments",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Writers_WriterID",
                table: "Comments",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
