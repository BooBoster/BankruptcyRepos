using BankruptcyTask.DAL;
using BankruptcyTask.DAL.Interfaces;
using BankruptcyTask.DAL.Repositories;
using BankruptcyTask.Service.Implemetations;
using BankruptcyTask.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

InitializeService(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

static void InitializeService(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddControllersWithViews();
    builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
    builder.Services.AddScoped<IEstateRepository, EstateRepository>();
    builder.Services.AddScoped<IEstateService, EstateService>();
    builder.Services.AddScoped<IDebtorRepository, DebtorRepository>();
    builder.Services.AddScoped<IDebtorService, DebtorService>();
    builder.Services.AddSwaggerGen();
}