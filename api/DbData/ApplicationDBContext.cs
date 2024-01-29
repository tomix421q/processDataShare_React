using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.DbData
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContenxtOptions) : base(dbContenxtOptions)
        {

        }

        public DbSet<AsqModel> AsqDatas { get; set; }

    }

}
