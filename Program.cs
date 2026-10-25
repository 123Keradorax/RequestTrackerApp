using RequestTracker.Repositories;
using RequestTracker.Services;

var builder = WebApplication.CreateBuilder(args);

// Добавление контроллеров и генератора документации Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрация слоев архитектуры в DI-контейнере
builder.Services.AddSingleton<IRequestRepository, JsonRequestRepository>();
builder.Services.AddScoped<IRequestService, RequestService>();

var app = builder.Build();

// Включение Swagger в среде разработки
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllers();

app.Run();
