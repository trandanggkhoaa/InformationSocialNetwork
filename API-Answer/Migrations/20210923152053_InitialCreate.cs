using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Answer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerManagement",
                columns: table => new
                {
                    ans_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ans_cont = table.Column<string>(type: "varchar(500)", nullable: true),
                    qst_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    img_url = table.Column<string>(type: "varchar(100)", nullable: true),
                    ref_url = table.Column<string>(type: "varchar(100)", nullable: true),
                    rating = table.Column<string>(type: "varchar(20)", nullable: true),
                    isActive = table.Column<string>(type: "char(1)", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerManagement", x => x.ans_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerManagement");
        }
    }
}
