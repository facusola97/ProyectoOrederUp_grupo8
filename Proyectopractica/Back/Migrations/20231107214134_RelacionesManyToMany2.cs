using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesManyToMany2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredientesOpciones_ingredientes_IngredientesIdIngredientes",
                table: "ingredientesOpciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ingredientesOpciones_opciones_OpcionIdOpcion",
                table: "ingredientesOpciones");

            migrationBuilder.RenameColumn(
                name: "OpcionIdOpcion",
                table: "ingredientesOpciones",
                newName: "IdOpcion");

            migrationBuilder.RenameColumn(
                name: "IngredientesIdIngredientes",
                table: "ingredientesOpciones",
                newName: "IdIngrediente");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientesOpciones_OpcionIdOpcion",
                table: "ingredientesOpciones",
                newName: "IX_ingredientesOpciones_IdOpcion");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientesOpciones_IngredientesIdIngredientes",
                table: "ingredientesOpciones",
                newName: "IX_ingredientesOpciones_IdIngrediente");

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientesOpciones_ingredientes_IdIngrediente",
                table: "ingredientesOpciones",
                column: "IdIngrediente",
                principalTable: "ingredientes",
                principalColumn: "IdIngredientes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientesOpciones_opciones_IdOpcion",
                table: "ingredientesOpciones",
                column: "IdOpcion",
                principalTable: "opciones",
                principalColumn: "IdOpcion",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredientesOpciones_ingredientes_IdIngrediente",
                table: "ingredientesOpciones");

            migrationBuilder.DropForeignKey(
                name: "FK_ingredientesOpciones_opciones_IdOpcion",
                table: "ingredientesOpciones");

            migrationBuilder.RenameColumn(
                name: "IdOpcion",
                table: "ingredientesOpciones",
                newName: "OpcionIdOpcion");

            migrationBuilder.RenameColumn(
                name: "IdIngrediente",
                table: "ingredientesOpciones",
                newName: "IngredientesIdIngredientes");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientesOpciones_IdOpcion",
                table: "ingredientesOpciones",
                newName: "IX_ingredientesOpciones_OpcionIdOpcion");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientesOpciones_IdIngrediente",
                table: "ingredientesOpciones",
                newName: "IX_ingredientesOpciones_IngredientesIdIngredientes");

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientesOpciones_ingredientes_IngredientesIdIngredientes",
                table: "ingredientesOpciones",
                column: "IngredientesIdIngredientes",
                principalTable: "ingredientes",
                principalColumn: "IdIngredientes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientesOpciones_opciones_OpcionIdOpcion",
                table: "ingredientesOpciones",
                column: "OpcionIdOpcion",
                principalTable: "opciones",
                principalColumn: "IdOpcion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
