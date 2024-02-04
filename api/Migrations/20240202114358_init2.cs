using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EqcDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    connection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actualDowntime = table.Column<short>(type: "smallint", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineAuto = table.Column<bool>(type: "bit", nullable: false),
                    ConveyorOK = table.Column<bool>(type: "bit", nullable: false),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    ToolHome = table.Column<bool>(type: "bit", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotAutomaticMode = table.Column<bool>(type: "bit", nullable: false),
                    RobotRunning = table.Column<bool>(type: "bit", nullable: false),
                    RobotHome = table.Column<bool>(type: "bit", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EqcDatas");
        }
    }
}
