using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Add_Message_table_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageReceiver_Message_MessageID",
                table: "MessageReceiver");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageReceiver_Writers_WriterID",
                table: "MessageReceiver");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageSender_Message_MessageID",
                table: "MessageSender");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageSender_Writers_WriterID",
                table: "MessageSender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageSender",
                table: "MessageSender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageReceiver",
                table: "MessageReceiver");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.RenameTable(
                name: "MessageSender",
                newName: "MessageSenders");

            migrationBuilder.RenameTable(
                name: "MessageReceiver",
                newName: "MessageReceivers");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameIndex(
                name: "IX_MessageSender_MessageID",
                table: "MessageSenders",
                newName: "IX_MessageSenders_MessageID");

            migrationBuilder.RenameIndex(
                name: "IX_MessageReceiver_MessageID",
                table: "MessageReceivers",
                newName: "IX_MessageReceivers_MessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageSenders",
                table: "MessageSenders",
                columns: new[] { "WriterID", "MessageID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageReceivers",
                table: "MessageReceivers",
                columns: new[] { "WriterID", "MessageID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageReceivers_Messages_MessageID",
                table: "MessageReceivers",
                column: "MessageID",
                principalTable: "Messages",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageReceivers_Writers_WriterID",
                table: "MessageReceivers",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageSenders_Messages_MessageID",
                table: "MessageSenders",
                column: "MessageID",
                principalTable: "Messages",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageSenders_Writers_WriterID",
                table: "MessageSenders",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageReceivers_Messages_MessageID",
                table: "MessageReceivers");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageReceivers_Writers_WriterID",
                table: "MessageReceivers");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageSenders_Messages_MessageID",
                table: "MessageSenders");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageSenders_Writers_WriterID",
                table: "MessageSenders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageSenders",
                table: "MessageSenders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageReceivers",
                table: "MessageReceivers");

            migrationBuilder.RenameTable(
                name: "MessageSenders",
                newName: "MessageSender");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "MessageReceivers",
                newName: "MessageReceiver");

            migrationBuilder.RenameIndex(
                name: "IX_MessageSenders_MessageID",
                table: "MessageSender",
                newName: "IX_MessageSender_MessageID");

            migrationBuilder.RenameIndex(
                name: "IX_MessageReceivers_MessageID",
                table: "MessageReceiver",
                newName: "IX_MessageReceiver_MessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageSender",
                table: "MessageSender",
                columns: new[] { "WriterID", "MessageID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "MessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageReceiver",
                table: "MessageReceiver",
                columns: new[] { "WriterID", "MessageID" });

            migrationBuilder.AddForeignKey(
                name: "FK_MessageReceiver_Message_MessageID",
                table: "MessageReceiver",
                column: "MessageID",
                principalTable: "Message",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageReceiver_Writers_WriterID",
                table: "MessageReceiver",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageSender_Message_MessageID",
                table: "MessageSender",
                column: "MessageID",
                principalTable: "Message",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageSender_Writers_WriterID",
                table: "MessageSender",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
