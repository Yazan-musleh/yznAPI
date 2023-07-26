using Microsoft.EntityFrameworkCore;
using yzn_web.Domain.Model.Repositories;
using yzn_web.Domain.Model.Services;
using yzn_web.Domain.Model.Services.Communication;
using yzn_web.Persistance.Context;
using yzn_web.Persistance.Repository;
using yzn_web.Services.BlogServices;
using yzn_web.Services.Coummunication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DataContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IBlogRepo, BlogRepo>();
builder.Services.AddScoped<IBlogService, BlogService>();

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
