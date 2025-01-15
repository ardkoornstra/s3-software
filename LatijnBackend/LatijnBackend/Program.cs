using LatijnAPI;
using LatijnData;
using LatijnData.Repositories;
using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                      });
});

// Add services to the container.
string connectionstring = builder.Configuration["LatijnDB"];
builder.Services.AddDbContext<LatijnDbContext>(options => options.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring)));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddSwaggerGen();

//Dependencies
builder.Services.AddScoped<IWerkwoordenLogic, WerkwoordenLogic>();
builder.Services.AddScoped<IUitgangenLogic, UitgangenLogic>();
builder.Services.AddScoped<IVervoegingenLogic, VervoegingenLogic>();
builder.Services.AddScoped<IToetsenLogic, ToetsenLogic>();
builder.Services.AddScoped<IVragenLogic, VragenLogic>();

builder.Services.AddScoped<IWerkwoordenData, WerkwoordenData>();
builder.Services.AddScoped<IUitgangenData, UitgangenData>();
builder.Services.AddScoped<IVervoegingenData, VervoegingenData>();
builder.Services.AddScoped<IToetsenData, ToetsenData>();
builder.Services.AddScoped<IRandomNumbers, RandomNumbers>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
