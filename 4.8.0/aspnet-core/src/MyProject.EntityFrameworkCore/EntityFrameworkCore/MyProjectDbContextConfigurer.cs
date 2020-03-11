using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyProject.EntityFrameworkCore
{
    public static class MyProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
            //builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
            //builder.UseSqlServer(connection);
        }
    }
}
