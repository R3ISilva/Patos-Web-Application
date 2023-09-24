using PatosPrint;
using PrintService.Models.Balance;
using PrintService.Models.Print;
using PrintService.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IBalanceService, BalanceService>(); // Register IBalanceService
builder.Services.AddScoped<IPrintService, PrintServiceWithBalance>(); //dependency injection? 
builder.Services.AddSingleton<IRepositoryService, MockService>(); // Register IRepositoryService

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