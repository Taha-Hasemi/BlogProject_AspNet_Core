using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Add_Admin_and_Role_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Message_Writers_RecieverID",
            //    table: "Message");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Message_Writers_SenderID",
            //    table: "Message");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Message",
            //    table: "Message");

            //migrationBuilder.RenameTable(
            //    name: "Message",
            //    newName: "Messages");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Message_SenderID",
            //    table: "Messages",
            //    newName: "IX_Messages_SenderID");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Message_RecieverID",
            //    table: "Messages",
            //    newName: "IX_Messages_RecieverID");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Messages",
            //    table: "Messages",
            //    column: "MessageID");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleColor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admins_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_RoleID",
                table: "Admins",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_RecieverID",
                table: "Messages",
                column: "RecieverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_SenderID",
                table: "Messages",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_RecieverID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_SenderID",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_SenderID",
                table: "Message",
                newName: "IX_Message_SenderID");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RecieverID",
                table: "Message",
                newName: "IX_Message_RecieverID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Writers_RecieverID",
                table: "Message",
                column: "RecieverID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Writers_SenderID",
                table: "Message",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
