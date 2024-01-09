using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Itis.DotnetExam.BLL.Migrations
{
    public partial class AddMonsters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HitPoints = table.Column<int>(type: "integer", nullable: false),
                    AttackModifier = table.Column<int>(type: "integer", nullable: false),
                    AttackPerRound = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<string>(type: "text", nullable: false),
                    DamageModifier = table.Column<int>(type: "integer", nullable: false),
                    ArmorClass = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "ArmorClass", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Name" },
                values: new object[,]
                {
                    { new Guid("421143b6-ab70-431c-8588-a3b9ed4a03bd"), 15, 4, 1, "1d8", 2, 20, "Gikitru" },
                    { new Guid("8f9d185c-9976-4b7c-b1d4-1cf6b5b5b6b7"), 10, 3, 1, "1d4", 0, 8, "Gorulus" },
                    { new Guid("9bd456a1-1524-4445-89d9-976008fdd8c9"), 18, 10, 3, "2d10", 5, 100, "Vapodus" },
                    { new Guid("b1e92c4d-6670-4b4d-99cb-2d5ec1cda474"), 12, 2, 2, "1d6", 1, 10, "Negrintuk" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monsters");
        }
    }
}
