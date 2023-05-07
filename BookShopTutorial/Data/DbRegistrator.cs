using BookShopTutorial.DBL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace BookShopTutorial.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<BookShopDB>(opt =>
            {
                var type = configuration["Type"];
                switch(type)
                {
                    case null: throw new InvalidOperationException("Не определен тип БД");
                    default : throw new InvalidOperationException($"Тип подключения {type} не поддерживается");
                    case "MSSQL":
                        opt.UseSqlServer(configuration.GetConnectionString(type), b => b.MigrationsAssembly("BookShopTutorial"));
                        break;
                    case "SQLite": 
                        opt.UseSqlite(configuration.GetConnectionString(type));
                        break;
                    case "InMemory":
                        opt.UseInMemoryDatabase(configuration.GetConnectionString(type)); 
                        break;
                }
            });
    }
}
