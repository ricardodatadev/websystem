using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace MyProject.Data
{
    public class MyProjectContextFactory : IDesignTimeDbContextFactory<MyProjectContext>
    {
        public MyProjectContext CreateDbContext(string[] args)
        {
            // Lê obrigatoriamente do .env
            var server = Environment.GetEnvironmentVariable("MYSQL_HOST")
                         ?? throw new InvalidOperationException("MYSQL_HOST não definido");
            var port = Environment.GetEnvironmentVariable("MYSQL_PORT")
                       ?? throw new InvalidOperationException("MYSQL_PORT não definido");
            var database = Environment.GetEnvironmentVariable("MYSQL_DATABASE")
                           ?? throw new InvalidOperationException("MYSQL_DATABASE não definido");
            var user = Environment.GetEnvironmentVariable("MYSQL_USER")
                       ?? throw new InvalidOperationException("MYSQL_USER não definido");
            var password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD")
                           ?? throw new InvalidOperationException("MYSQL_PASSWORD não definido");

            var connectionString = $"Server={server};Port={port};Database={database};User={user};Password={password};";

            var optionsBuilder = new DbContextOptionsBuilder<MyProjectContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new MyProjectContext(optionsBuilder.Options);
        }
    }
}
