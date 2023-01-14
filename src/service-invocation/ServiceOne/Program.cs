using Common.Helpers;
using Common.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IDaprClientHelper, DaprClientHelper>();
builder.Services.AddTransient<IServiceTwoHelper, ServiceTwoHelper>();

builder.Services.AddControllers().AddJsonOptions(s => s.JsonSerializerOptions.PropertyNamingPolicy = null).AddDapr();
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

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

