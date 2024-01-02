using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarhangbookStore.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class MIG_DbInit14021012 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBLProductPublishers",
                columns: table => new
                {
                    Publisherid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherFaTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PublisherEnTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLProductPublishers", x => x.Publisherid);
                });

            migrationBuilder.CreateTable(
                name: "TBLProductSizeBooks",
                columns: table => new
                {
                    SizeBookid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeBookName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    SizeBook = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLProductSizeBooks", x => x.SizeBookid);
                });

            migrationBuilder.CreateTable(
                name: "TBLProductWriters",
                columns: table => new
                {
                    Writerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterFaTitle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    WriterEnTitle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLProductWriters", x => x.Writerid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBLProductPublishers");

            migrationBuilder.DropTable(
                name: "TBLProductSizeBooks");

            migrationBuilder.DropTable(
                name: "TBLProductWriters");
        }
    }
}
