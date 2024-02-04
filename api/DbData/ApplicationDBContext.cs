using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.DbData
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContenxtOptions) : base(dbContenxtOptions)
        {

        }
        // ASQ
        public DbSet<AsqModel> AsqDatas_asq2 { get; set; }
        public DbSet<AsqModel> AsqDatas_asq3 { get; set; }
        public DbSet<AsqModel> AsqDatas_asq4 { get; set; }
        public DbSet<AsqModel> AsqDatas_asq5 { get; set; }
        public DbSet<AsqModel> AsqDatas_asq6 { get; set; }
        // EQC
        public DbSet<EqcModel> EqcDatas_eqc1 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc2 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc3 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc4 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc5 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc6 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc7 { get; set; }
        public DbSet<EqcModel> EqcDatas_eqc8 { get; set; }
    }

}
