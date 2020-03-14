using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Data.Common;

namespace MyProject.EntityFrameworkCore
{
    public static class MyProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyProjectDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
            //builder.UseLoggerFactory(MyLoggerFactory).UseMySql(connectionString);
            //builder.UseNpgsql(connectionString);
            //builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyProjectDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
            //builder.UseNpgsql(connection);
            //builder.UseSqlServer(connection);
        }
        //public static readonly LoggerFactory MyLoggerFactory
        //= new LoggerFactory(new[]
        //{
        //    new ConsoleLoggerProvider((category, level)
        //        => category == DbLoggerCategory.Database.Command.Name
        //           && level == LogLevel.Information, true)
        //});
    }
}
