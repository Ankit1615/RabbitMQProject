
// it will create kestral web server
using Newtonsoft.Json.Serialization;
using ONLINESHOP_API.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// call controller from the browser
builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
                = new DefaultContractResolver()); ;



builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();


app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.Run();











