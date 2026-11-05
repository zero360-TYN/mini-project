using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mini_project.Migrations
{
    /// <inheritdoc />
    public partial class testupdatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "SampleEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "value",
                table: "SampleEntities");
        }
    }
}
