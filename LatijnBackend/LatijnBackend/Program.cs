using LatijnAPI.Models;
using LatijnData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionstring = builder.Configuration["LatijnDB"];
builder.Services.AddDbContext<LatijnDbContext>(options => options.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring)));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependencies
//builder.Services.AddScoped<IWerkwoordenLogic, WerkwoordenLogic>();
//builder.Services.AddScoped<IWerkwoordenLogic>(sp => new WerkwoordenLogic(new WerkwoordenDataAccess()));
//builder.Services.AddScoped<IWerkwoordenDataAccess, WerkwoordenDataAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
