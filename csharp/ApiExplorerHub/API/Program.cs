using API.Extensions;
using API.Storage;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServicesCollection(builder.Configuration);

var app = builder.Build();
app.Services.AddCustomServices(builder.Configuration);
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.UseCors("CorsPolicy");

app.Run();

