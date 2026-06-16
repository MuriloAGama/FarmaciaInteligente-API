using FarmaciaInteligenteAPI.src.Middlewares;
using FarmaciaInteligenteAPI.src.Services;
using FarmaciaInteligenteAPI.src.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona Controllers
builder.Services.AddControllers();

// Adiciona Validação e Injeção de Dependência
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<MedicamentoValidator>();
builder.Services.AddScoped<IMedicamentoService, MedicamentoService>();

var app = builder.Build();

// Pipeline de Middleware
app.UseMiddleware<ErrorHandlingMiddleware>();
app.MapControllers();

app.Run();