using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class CreateClienteDomicilioPagoReciboTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domicilios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CallePrincipal = table.Column<string>(nullable: true),
                    CalleA = table.Column<string>(nullable: true),
                    CalleB = table.Column<string>(nullable: true),
                    NumeroExterior = table.Column<int>(nullable: false),
                    NumeroInterior = table.Column<int>(nullable: false),
                    CodigoPostal = table.Column<int>(nullable: false),
                    Municipio = table.Column<string>(nullable: true),
                    Localidad = table.Column<string>(nullable: true),
                    Colonia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Folio = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreDelTitular = table.Column<string>(maxLength: 100, nullable: false),
                    Tarjeta = table.Column<string>(maxLength: 20, nullable: false),
                    Autorizacion = table.Column<int>(nullable: false),
                    FechaDePago = table.Column<DateTime>(nullable: false),
                    Banco = table.Column<string>(maxLength: 200, nullable: false),
                    Importe = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Folio);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cuenta = table.Column<int>(nullable: false),
                        // .Annotation("Sqlite:Autoincrement", false),
                    Contrato = table.Column<int>(nullable: false),
                    Medidor = table.Column<string>(nullable: true),
                    ClaveDeLocalizacion = table.Column<string>(nullable: true),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    RazonSocial = table.Column<string>(nullable: true),
                    Rfc = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    CorreoElectronico = table.Column<string>(nullable: true),
                    DomicilioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cuenta);
                    table.ForeignKey(
                        name: "FK_Clientes_Domicilios_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PeriodoDeFacturacion = table.Column<string>(nullable: true),
                    FechaDeInicio = table.Column<DateTime>(nullable: false),
                    FechaDeLectura = table.Column<DateTime>(nullable: false),
                    LecturaAnterior = table.Column<int>(nullable: false),
                    LecturaActual = table.Column<int>(nullable: false),
                    ConsumoEnM3 = table.Column<int>(nullable: false),
                    MesesDeAdeudo = table.Column<int>(nullable: false),
                    Consumo = table.Column<double>(nullable: false),
                    Drenaje = table.Column<double>(nullable: false),
                    Saneamiento = table.Column<double>(nullable: false),
                    Bomberos = table.Column<double>(nullable: false),
                    CruzRoja = table.Column<double>(nullable: false),
                    Multas = table.Column<double>(nullable: false),
                    Recargos = table.Column<double>(nullable: false),
                    ImporteTotal = table.Column<double>(nullable: false),
                    ClienteCuenta = table.Column<int>(nullable: false),
                    PagoFolio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recibos_Clientes_ClienteCuenta",
                        column: x => x.ClienteCuenta,
                        principalTable: "Clientes",
                        principalColumn: "Cuenta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recibos_Pagos_PagoFolio",
                        column: x => x.PagoFolio,
                        principalTable: "Pagos",
                        principalColumn: "Folio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_DomicilioId",
                table: "Clientes",
                column: "DomicilioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_ClienteCuenta",
                table: "Recibos",
                column: "ClienteCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_PagoFolio",
                table: "Recibos",
                column: "PagoFolio",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Domicilios");
        }
    }
}
