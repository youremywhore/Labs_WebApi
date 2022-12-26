﻿using Contracts;
using LoggerService;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace LR_WEB_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
 services.AddCors(options =>
 {
     options.AddPolicy("CorsPolicy", builder =>
     builder.AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
 });
        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options =>
 {

 });
        public static void ConfigureLoggerService(this IServiceCollection services) =>
 services.AddScoped<ILoggerManager, LoggerManager>();

            public static void ConfigureSqlContext(this IServiceCollection services,
     IConfiguration configuration) =>
     services.AddDbContext<RepositoryContext>(opts =>
     opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
     b.MigrationsAssembly("LR_WEB_API")));

        public static void ConfigureRepositoryManager(this IServiceCollection services)
=>
 services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
            
}
