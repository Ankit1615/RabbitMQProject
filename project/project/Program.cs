// it will create kestral web server
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;
using project.Controllers;



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



app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot")),
    RequestPath = new PathString("/wwwroot")
});
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.Run();