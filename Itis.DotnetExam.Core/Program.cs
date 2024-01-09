using Itis.DotnetExam.BLL;
using Itis.DotnetExam.BLL.Contracts;
using Itis.DotnetExam.BLL.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbContext, EfContext>();
builder.Services.AddDbContext<EfContext>(
    opt =>
    {
        opt.UseNpgsql(builder.Configuration["Application:DbConnectionString"]!);
    }
);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();