using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MMORPG.Game.Service.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_abilitie",
                columns: table => new
                {
                    cd_abilitie_pk = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nm_name = table.Column<string>(type: "TEXT", nullable: false),
                    nm_description = table.Column<string>(type: "TEXT", nullable: false),
                    nm_command = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_abilitie", x => x.cd_abilitie_pk);
                });

            migrationBuilder.CreateTable(
                name: "tb_item",
                columns: table => new
                {
                    cd_item_pk = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nm_name = table.Column<string>(type: "TEXT", nullable: false),
                    nm_description = table.Column<string>(type: "TEXT", nullable: false),
                    nr_damage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_item", x => x.cd_item_pk);
                });

            migrationBuilder.CreateTable(
                name: "tb_person",
                columns: table => new
                {
                    cd_person_pk = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nm_name = table.Column<string>(type: "TEXT", nullable: false),
                    nr_years = table.Column<int>(type: "INTEGER", nullable: false),
                    nr_kills = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_person", x => x.cd_person_pk);
                });

            migrationBuilder.CreateTable(
                name: "rl_abilitie_item",
                columns: table => new
                {
                    cd_abilitie_item_pk = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cd_abilitie_fk = table.Column<int>(type: "INTEGER", nullable: false),
                    cd_item_fk = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rl_abilitie_item", x => x.cd_abilitie_item_pk);
                    table.ForeignKey(
                        name: "FK_rl_abilitie_item_tb_abilitie_cd_abilitie_fk",
                        column: x => x.cd_abilitie_fk,
                        principalTable: "tb_abilitie",
                        principalColumn: "cd_abilitie_pk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rl_abilitie_item_tb_item_cd_item_fk",
                        column: x => x.cd_item_fk,
                        principalTable: "tb_item",
                        principalColumn: "cd_item_pk",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rl_abilitie_person",
                columns: table => new
                {
                    cd_abilitie_person_pk = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cd_person_fk = table.Column<int>(type: "INTEGER", nullable: false),
                    cd_abilitie_fk = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rl_abilitie_person", x => x.cd_abilitie_person_pk);
                    table.ForeignKey(
                        name: "FK_rl_abilitie_person_tb_abilitie_cd_abilitie_fk",
                        column: x => x.cd_abilitie_fk,
                        principalTable: "tb_abilitie",
                        principalColumn: "cd_abilitie_pk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rl_abilitie_person_tb_person_cd_person_fk",
                        column: x => x.cd_person_fk,
                        principalTable: "tb_person",
                        principalColumn: "cd_person_pk",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rl_person_item",
                columns: table => new
                {
                    cd_person_item_pk = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cd_person_fk = table.Column<int>(type: "INTEGER", nullable: false),
                    cd_item_fk = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rl_person_item", x => x.cd_person_item_pk);
                    table.ForeignKey(
                        name: "FK_rl_person_item_tb_item_cd_item_fk",
                        column: x => x.cd_item_fk,
                        principalTable: "tb_item",
                        principalColumn: "cd_item_pk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rl_person_item_tb_person_cd_person_fk",
                        column: x => x.cd_person_fk,
                        principalTable: "tb_person",
                        principalColumn: "cd_person_pk",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rl_abilitie_item_cd_abilitie_fk",
                table: "rl_abilitie_item",
                column: "cd_abilitie_fk");

            migrationBuilder.CreateIndex(
                name: "IX_rl_abilitie_item_cd_item_fk",
                table: "rl_abilitie_item",
                column: "cd_item_fk");

            migrationBuilder.CreateIndex(
                name: "IX_rl_abilitie_person_cd_abilitie_fk",
                table: "rl_abilitie_person",
                column: "cd_abilitie_fk");

            migrationBuilder.CreateIndex(
                name: "IX_rl_abilitie_person_cd_person_fk",
                table: "rl_abilitie_person",
                column: "cd_person_fk");

            migrationBuilder.CreateIndex(
                name: "IX_rl_person_item_cd_item_fk",
                table: "rl_person_item",
                column: "cd_item_fk");

            migrationBuilder.CreateIndex(
                name: "IX_rl_person_item_cd_person_fk",
                table: "rl_person_item",
                column: "cd_person_fk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rl_abilitie_item");

            migrationBuilder.DropTable(
                name: "rl_abilitie_person");

            migrationBuilder.DropTable(
                name: "rl_person_item");

            migrationBuilder.DropTable(
                name: "tb_abilitie");

            migrationBuilder.DropTable(
                name: "tb_item");

            migrationBuilder.DropTable(
                name: "tb_person");
        }
    }
}
