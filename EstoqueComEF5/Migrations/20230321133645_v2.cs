using Microsoft.EntityFrameworkCore.Migrations;

namespace EstoqueComEF5.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "Produtos");

          
        }
    }
}
