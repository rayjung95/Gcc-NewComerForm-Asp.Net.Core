using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Gccform.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    company_name = table.Column<string>(maxLength: 100, nullable: true),
                    dob = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    job = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PersonID = table.Column<int>(nullable: false),
                    city = table.Column<string>(maxLength: 100, nullable: true),
                    postal_code = table.Column<string>(maxLength: 100, nullable: true),
                    street1 = table.Column<string>(maxLength: 100, nullable: true),
                    street2 = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Churches",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PersonID = table.Column<int>(nullable: false),
                    baptized_church = table.Column<string>(maxLength: 100, nullable: true),
                    baptized_date = table.Column<DateTime>(nullable: false),
                    friends_in_church = table.Column<string>(maxLength: 100, nullable: true),
                    infant_baptized_church = table.Column<string>(maxLength: 100, nullable: true),
                    infant_baptized_date = table.Column<DateTime>(nullable: false),
                    last_church_leader = table.Column<string>(maxLength: 100, nullable: true),
                    last_church_name = table.Column<string>(maxLength: 100, nullable: true),
                    person_status = table.Column<string>(maxLength: 100, nullable: true),
                    position_type = table.Column<string>(maxLength: 100, nullable: true),
                    vehicle_license = table.Column<string>(maxLength: 100, nullable: true),
                    volunteer_experience = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Churches", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Churches_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PersonID = table.Column<int>(nullable: false),
                    home_num = table.Column<string>(maxLength: 100, nullable: true),
                    phone_num = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonNames",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PersonID = table.Column<int>(nullable: false),
                    e_fname = table.Column<string>(maxLength: 100, nullable: true),
                    e_lname = table.Column<string>(maxLength: 100, nullable: true),
                    k_fname = table.Column<string>(maxLength: 100, nullable: true),
                    k_lname = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonNames", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonNames_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonID",
                table: "Addresses",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Churches_PersonID",
                table: "Churches",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PersonID",
                table: "Contacts",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonNames_PersonID",
                table: "PersonNames",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Churches");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "PersonNames");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
