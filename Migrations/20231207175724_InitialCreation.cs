using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_ecommerce.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_productos",
                columns: table => new
                {
                    it_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    it_descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    it_precio = table.Column<double>(type: "float", nullable: false),
                    it_estado = table.Column<bool>(type: "bit", nullable: false),
                    it_detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    it_imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_productos", x => x.it_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_productos");
        }
    }
}
