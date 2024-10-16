using AutoMapper;
using Jornada.AutoMapper;
using Jornada.Business;
using Jornada.contracts.IRepository;
using Jornada.contracts.IService;
using Jornada.Repository.Context;
using Jornada.Repository.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<JornadaContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Service
builder.Services.AddScoped<IAlunoService, AlunoService>();

//Repository
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

ConfigureAutoMapper(builder.Services);


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
static void ConfigureAutoMapper(IServiceCollection services)
{
    services.RegisterMappings();

}


