using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using App;
var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddDbContext<TestContext>(p=>p.UseMySQL("server=localhost;database=Test;user=root;password=root"));

var app = builder.Build();


app.MapGet("/", ([FromServices] TestContext dbContext)=> {
  return Results.Ok($"La base de datos se creo");
});

app.Run();
