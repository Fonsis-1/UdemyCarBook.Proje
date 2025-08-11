using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_update_authorid_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDatat",
                table: "Blogs",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "AutgorID",
                table: "Blogs",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Blogs",
                newName: "AutgorID");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Blogs",
                newName: "CreatedDatat");
        }
    }
}
