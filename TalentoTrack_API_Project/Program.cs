using Microsoft.EntityFrameworkCore;
using TalentoTrack_Common.Repositories;
using TalentoTrack_Common.Services;
using TalentoTrack_Dao.DB;
using TalentoTrack_Dao.Repositories;
using TalentoTrack_Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddTransient<IAccountRepository, AccountRepository>();


builder.Services.AddDbContext<TalentoTrack_DbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
