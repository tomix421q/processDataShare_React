﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.DbData;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240206092206_utorok")]
    partial class utorok
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.databaseModels.ASQ.Db_asq2Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Global_GoWeightAfter")
                        .HasColumnType("int");

                    b.Property<float>("Global_MixingTime")
                        .HasColumnType("real");

                    b.Property<float>("Global_RefValue")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolMinus")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolPlus")
                        .HasColumnType("real");

                    b.Property<int>("ROB1_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB1_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB1_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<int>("ROB2_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB2_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB2_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<string>("connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AsqDatas_asq2");
                });

            modelBuilder.Entity("api.Models.databaseModels.ASQ.Db_asq3Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Global_GoWeightAfter")
                        .HasColumnType("int");

                    b.Property<float>("Global_MixingTime")
                        .HasColumnType("real");

                    b.Property<float>("Global_RefValue")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolMinus")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolPlus")
                        .HasColumnType("real");

                    b.Property<int>("ROB1_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB1_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB1_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<int>("ROB2_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB2_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB2_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<string>("connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AsqDatas_asq3");
                });

            modelBuilder.Entity("api.Models.databaseModels.ASQ.Db_asq4Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Global_GoWeightAfter")
                        .HasColumnType("int");

                    b.Property<float>("Global_MixingTime")
                        .HasColumnType("real");

                    b.Property<float>("Global_RefValue")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolMinus")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolPlus")
                        .HasColumnType("real");

                    b.Property<int>("ROB1_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB1_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB1_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<int>("ROB2_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB2_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB2_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<string>("connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AsqDatas_asq4");
                });

            modelBuilder.Entity("api.Models.databaseModels.ASQ.Db_asq5Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Global_GoWeightAfter")
                        .HasColumnType("int");

                    b.Property<float>("Global_MixingTime")
                        .HasColumnType("real");

                    b.Property<float>("Global_RefValue")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolMinus")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolPlus")
                        .HasColumnType("real");

                    b.Property<int>("ROB1_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB1_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB1_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<int>("ROB2_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB2_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB2_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<string>("connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AsqDatas_asq5");
                });

            modelBuilder.Entity("api.Models.databaseModels.ASQ.Db_asq6Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Global_GoWeightAfter")
                        .HasColumnType("int");

                    b.Property<float>("Global_MixingTime")
                        .HasColumnType("real");

                    b.Property<float>("Global_RefValue")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolMinus")
                        .HasColumnType("real");

                    b.Property<float>("Global_WeightTolPlus")
                        .HasColumnType("real");

                    b.Property<int>("ROB1_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB1_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB1_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB1_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<int>("ROB2_Downtime_Time")
                        .HasColumnType("int");

                    b.Property<int>("ROB2_FormNumber")
                        .HasColumnType("int");

                    b.Property<float>("ROB2_SetTemperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_Temperature")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_TimeDrying")
                        .HasColumnType("real");

                    b.Property<float>("ROB2_WeightActualValue")
                        .HasColumnType("real");

                    b.Property<string>("connection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AsqDatas_asq6");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc1Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc1");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc2Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc2");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc3Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc3");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc4Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc4");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc5Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc5");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc6Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc6");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc7Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc7");
                });

            modelBuilder.Entity("api.Models.databaseModels.EQC.Db_eqc8Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("ActualPressure")
                        .HasColumnType("real");

                    b.Property<string>("ActualToolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Actual_AirInside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside2")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirInside3")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("Actual_AirOutside2")
                        .HasColumnType("real");

                    b.Property<bool>("BluemeltOk")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<int>("RobotToolNumber")
                        .HasColumnType("int");

                    b.Property<float>("SetAirInside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside2")
                        .HasColumnType("real");

                    b.Property<float>("SetAirInside3")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside1")
                        .HasColumnType("real");

                    b.Property<float>("SetAirOutside2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed1")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed2")
                        .HasColumnType("real");

                    b.Property<float>("SetpumpSpeed3")
                        .HasColumnType("real");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcDatas_eqc8");
                });
#pragma warning restore 612, 618
        }
    }
}
