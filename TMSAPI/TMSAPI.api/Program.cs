using Microsoft.EntityFrameworkCore;
using TMSAPI.api.Data;
using TMSAPI.api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dbcontexts

builder.Services.AddDbContext<XAMControlX4Context>(
   options =>
   {
       options.UseSqlServer(builder.Configuration.GetConnectionString("XAMControlX4"));

   }
   );


builder.Services.AddDbContext<XAMRuntimeX4Context>(
   options =>
   {
       options.UseSqlServer(builder.Configuration.GetConnectionString("XAMRuntimeX4Context"));

   }
   );

//dbcontexts end

builder.Services.AddScoped<IAlarms, Alarms>();


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
