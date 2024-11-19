using BibliotecaDefinitiva.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("BibliotecaDatabase"),
        new MySqlServerVersion(new Version(8, 0, 31))

    ));

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
