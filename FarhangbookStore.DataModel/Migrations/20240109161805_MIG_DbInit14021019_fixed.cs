using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarhangbookStore.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class MIG_DbInit14021019_fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PropertyTitle",
                table: "TBLPropertyNames",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "TBLProductGroupBooks",
                columns: table => new
                {
                    GroupBookid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupBookTitle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLProductGroupBooks", x => x.GroupBookid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBLProductGroupBooks");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyTitle",
                table: "TBLPropertyNames",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);
        }
    }
}
