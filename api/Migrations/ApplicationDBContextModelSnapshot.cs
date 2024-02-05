﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.DbData;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Models.AsqModel", b =>
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

                    b.ToTable("AsqModel");
                });

            modelBuilder.Entity("api.Models.EqcModel", b =>
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

                    b.Property<bool>("ConveyorOK")
                        .HasColumnType("bit");

                    b.Property<float>("CycleTime")
                        .HasColumnType("real");

                    b.Property<bool>("HeaterOk")
                        .HasColumnType("bit");

                    b.Property<bool>("MachineAuto")
                        .HasColumnType("bit");

                    b.Property<int>("MainStepNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductionCurrentNum")
                        .HasColumnType("int");

                    b.Property<bool>("RobotAutomaticMode")
                        .HasColumnType("bit");

                    b.Property<bool>("RobotConnectedGripper")
                        .HasColumnType("bit");

                    b.Property<bool>("RobotHome")
                        .HasColumnType("bit");

                    b.Property<bool>("RobotRunning")
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

                    b.Property<bool>("ToolHome")
                        .HasColumnType("bit");

                    b.Property<int>("ToolNumber")
                        .HasColumnType("int");

                    b.Property<short>("actualDowntime")
                        .HasColumnType("smallint");

                    b.Property<string>("connection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EqcModel");
                });
#pragma warning restore 612, 618
        }
    }
}
