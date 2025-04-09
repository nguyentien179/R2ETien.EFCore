using Microsoft.EntityFrameworkCore;
using R2ETien.EFCore.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MigrateDb();

app.Run();
