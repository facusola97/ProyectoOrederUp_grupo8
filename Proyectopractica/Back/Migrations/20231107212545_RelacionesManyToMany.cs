using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientesOpcion");

            migrationBuilder.DropTable(
                name: "OpcionPedido");

            migrationBuilder.CreateTable(
                name: "ingredientesOpciones",
                columns: table => new
                {
                    IdIngredienteopcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientesIdIngredientes = table.Column<int>(type: "int", nullable: false),
                    OpcionIdOpcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingredientesOpciones", x => x.IdIngredienteopcion);
                    table.ForeignKey(
                        name: "FK_ingredientesOpciones_ingredientes_IngredientesIdIngredientes",
                        column: x => x.IngredientesIdIngredientes,
                        principalTable: "ingredientes",
                        principalColumn: "IdIngredientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ingredientesOpciones_opciones_OpcionIdOpcion",
                        column: x => x.OpcionIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ingredientesOpciones_IngredientesIdIngredientes",
                table: "ingredientesOpciones",
                column: "IngredientesIdIngredientes");

            migrationBuilder.CreateIndex(
                name: "IX_ingredientesOpciones_OpcionIdOpcion",
                table: "ingredientesOpciones",
                column: "OpcionIdOpcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ingredientesOpciones");

            migrationBuilder.CreateTable(
                name: "IngredientesOpcion",
                columns: table => new
                {
                    ingredientesIdIngredientes = table.Column<int>(type: "int", nullable: false),
                    opcionesIdOpcion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientesOpcion", x => new { x.ingredientesIdIngredientes, x.opcionesIdOpcion });
                    table.ForeignKey(
                        name: "FK_IngredientesOpcion_ingredientes_ingredientesIdIngredientes",
                        column: x => x.ingredientesIdIngredientes,
                        principalTable: "ingredientes",
                        principalColumn: "IdIngredientes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientesOpcion_opciones_opcionesIdOpcion",
                        column: x => x.opcionesIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpcionPedido",
                columns: table => new
                {
                    opcionesIdOpcion = table.Column<int>(type: "int", nullable: false),
                    pedidosIdPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionPedido", x => new { x.opcionesIdOpcion, x.pedidosIdPedido });
                    table.ForeignKey(
                        name: "FK_OpcionPedido_opciones_opcionesIdOpcion",
                        column: x => x.opcionesIdOpcion,
                        principalTable: "opciones",
                        principalColumn: "IdOpcion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpcionPedido_pedidos_pedidosIdPedido",
                        column: x => x.pedidosIdPedido,
                        principalTable: "pedidos",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientesOpcion_opcionesIdOpcion",
                table: "IngredientesOpcion",
                column: "opcionesIdOpcion");

            migrationBuilder.CreateIndex(
                name: "IX_OpcionPedido_pedidosIdPedido",
                table: "OpcionPedido",
                column: "pedidosIdPedido");
        }
    }
}
