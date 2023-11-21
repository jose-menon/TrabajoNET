using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrabajoNET.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    activity_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activity_title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    activity_description = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    activity_Iscompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.activity_id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "activity_id", "activity_description", "activity_Iscompleted", "activity_title" },
                values: new object[] { 1, "alaskja@sjasja.com", false, "46274628736" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "activity_id", "activity_description", "activity_Iscompleted", "activity_title" },
                values: new object[] { 2, "akja@sjasja.com", false, "46278736" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
