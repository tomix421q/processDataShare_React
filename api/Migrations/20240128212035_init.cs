using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsqDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROB1_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB1_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB1_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB1_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    ROB2_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB2_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB2_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB2_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    Global_RefValue = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolMinus = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolPlus = table.Column<float>(type: "real", nullable: false),
                    Global_GoWeightAfter = table.Column<int>(type: "int", nullable: false),
                    Global_MixingTime = table.Column<float>(type: "real", nullable: false),
                    connection = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsqDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsqDatas");
        }
    }
}
