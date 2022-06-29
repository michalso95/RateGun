using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RateGun.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessLvls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Permissions = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLvls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BulletCals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Descr = table.Column<string>(type: "TEXT", nullable: false),
                    Inventor = table.Column<string>(type: "TEXT", nullable: false),
                    InventorCountry = table.Column<string>(type: "TEXT", nullable: false),
                    YearInvented = table.Column<int>(type: "INTEGER", nullable: false),
                    YearProductionStart = table.Column<int>(type: "INTEGER", nullable: false),
                    YearProductionEnd = table.Column<int>(type: "INTEGER", nullable: false),
                    IsProduce = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BulletCals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GunPlants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Descr = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    YearEstablish = table.Column<int>(type: "INTEGER", nullable: false),
                    YearClose = table.Column<int>(type: "INTEGER", nullable: false),
                    IsRunning = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunPlants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagazineCapacities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagazineCapacities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    DescrGeneral = table.Column<string>(type: "TEXT", nullable: false),
                    DescrHistory = table.Column<string>(type: "TEXT", nullable: false),
                    DescrCuriosities = table.Column<string>(type: "TEXT", nullable: false),
                    EstablishYear = table.Column<int>(type: "INTEGER", nullable: false),
                    CloseYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AccessLvlId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Exp = table.Column<int>(type: "INTEGER", nullable: false),
                    Lvl = table.Column<int>(type: "INTEGER", nullable: false),
                    SignatureFooter = table.Column<string>(type: "TEXT", nullable: false),
                    Avatar = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_AccessLvls_AccessLvlId",
                        column: x => x.AccessLvlId,
                        principalTable: "AccessLvls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    GunPlantId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductionBegin = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductionFinish = table.Column<int>(type: "INTEGER", nullable: false),
                    MagazineCapacityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    BulletCalId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DescrGeneral = table.Column<string>(type: "TEXT", nullable: false),
                    DescrTech = table.Column<string>(type: "TEXT", nullable: false),
                    DescrCuriosities = table.Column<string>(type: "TEXT", nullable: false),
                    DescrHistory = table.Column<string>(type: "TEXT", nullable: false),
                    Bibliography = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guns_BulletCals_BulletCalId",
                        column: x => x.BulletCalId,
                        principalTable: "BulletCals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guns_GunPlants_GunPlantId",
                        column: x => x.GunPlantId,
                        principalTable: "GunPlants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guns_MagazineCapacities_MagazineCapacityId",
                        column: x => x.MagazineCapacityId,
                        principalTable: "MagazineCapacities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guns_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunPhoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    GunId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    PHOTO = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunPhoto_Guns_GunId",
                        column: x => x.GunId,
                        principalTable: "Guns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    GunId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RateGeneral = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateAccuarcy = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateDefaultAiming = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateFailureFree = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateMaterialQuality = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateLook = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateErgonomic = table.Column<decimal>(type: "TEXT", nullable: false),
                    RatePartsAddsAvailability = table.Column<decimal>(type: "TEXT", nullable: false),
                    RateModifiable = table.Column<decimal>(type: "TEXT", nullable: false),
                    DescrRate = table.Column<string>(type: "TEXT", nullable: false),
                    Visibility = table.Column<int>(type: "INTEGER", nullable: false),
                    NonCompilancePoints = table.Column<int>(type: "INTEGER", nullable: false),
                    Points = table.Column<int>(type: "INTEGER", nullable: false),
                    PublicationDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    BulletCalId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_BulletCals_BulletCalId",
                        column: x => x.BulletCalId,
                        principalTable: "BulletCals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Guns_GunId",
                        column: x => x.GunId,
                        principalTable: "Guns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GunPhoto_GunId",
                table: "GunPhoto",
                column: "GunId");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_BulletCalId",
                table: "Guns",
                column: "BulletCalId");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_GunPlantId",
                table: "Guns",
                column: "GunPlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_MagazineCapacityId",
                table: "Guns",
                column: "MagazineCapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_Guns_ManufacturerId",
                table: "Guns",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BulletCalId",
                table: "Reviews",
                column: "BulletCalId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GunId",
                table: "Reviews",
                column: "GunId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccessLvlId",
                table: "Users",
                column: "AccessLvlId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GunPhoto");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Guns");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BulletCals");

            migrationBuilder.DropTable(
                name: "GunPlants");

            migrationBuilder.DropTable(
                name: "MagazineCapacities");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "AccessLvls");
        }
    }
}
