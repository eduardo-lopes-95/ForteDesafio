using Forte.Ecommerce.Aplicacao;
using Forte.Ecommerce.Infraestrutura.CrossCutting.IOC;
using Forte.Ecommerce.Infraestrutura.Data.Contextos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Contexto>(c =>
    c.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionString")));

InjetorDependencias.Registrar(builder.Services);

builder.Services.AddAutoMapper(x => x.AddProfile(new MappingEntidade()));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
