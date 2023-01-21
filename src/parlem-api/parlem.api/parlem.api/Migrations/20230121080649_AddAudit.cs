using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JWTAuthentication.Migrations
{
    public partial class AddAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BorradoPorId",
                table: "Producto",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDelete",
                table: "Producto",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInsert",
                table: "Producto",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUpdate",
                table: "Producto",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserInsert",
                table: "Producto",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserUpdate",
                table: "Producto",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BorradoPorId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDelete",
                table: "Customers",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInsert",
                table: "Customers",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUpdate",
                table: "Customers",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserInsert",
                table: "Customers",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserUpdate",
                table: "Customers",
                maxLength: 450,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_BorradoPorId",
                table: "Producto",
                column: "BorradoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_UserInsert",
                table: "Producto",
                column: "UserInsert");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_UserUpdate",
                table: "Producto",
                column: "UserUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BorradoPorId",
                table: "Customers",
                column: "BorradoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserInsert",
                table: "Customers",
                column: "UserInsert");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserUpdate",
                table: "Customers",
                column: "UserUpdate");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_BorradoPorId",
                table: "Customers",
                column: "BorradoPorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UserInsert",
                table: "Customers",
                column: "UserInsert",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UserUpdate",
                table: "Customers",
                column: "UserUpdate",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_AspNetUsers_BorradoPorId",
                table: "Producto",
                column: "BorradoPorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_AspNetUsers_UserInsert",
                table: "Producto",
                column: "UserInsert",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_AspNetUsers_UserUpdate",
                table: "Producto",
                column: "UserUpdate",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_BorradoPorId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserInsert",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserUpdate",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_AspNetUsers_BorradoPorId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_AspNetUsers_UserInsert",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_AspNetUsers_UserUpdate",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_BorradoPorId",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_UserInsert",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_UserUpdate",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BorradoPorId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserInsert",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UserUpdate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BorradoPorId",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "FechaDelete",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "FechaInsert",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "FechaUpdate",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "UserInsert",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "UserUpdate",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "BorradoPorId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FechaDelete",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FechaInsert",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FechaUpdate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserInsert",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserUpdate",
                table: "Customers");
        }
    }
}
