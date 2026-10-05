using example.com.api.Repositories;
using example.com.api.Services;
using example.com.database.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = (new ConfigurationBuilder())
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables()
    .Build();

var dbConnection = configuration.GetConnectionString("Connection");
var dbProvider = configuration.GetConnectionString("Provider");
var corsPolicy = "CorsPolicy";
var corsDevPolicy = "CorsDevPolicy";
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi()
    .AddCors(options => options.AddPolicy(corsPolicy, policy =>
        {
            var allowedOrigin = configuration.GetSection("AllowedOrigin").Get<string[]>();
            policy.WithOrigins(allowedOrigin)
                .AllowAnyHeader()
                .AllowAnyMethod();
        })
   )
    .AddCors(options => options.AddPolicy(corsDevPolicy, policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        }
        ))
    .InstallDatabase(dbConnection)
    .AddScoped<ApprovalRepository>()
    .AddScoped<IApprovalService,ApprovalService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseCors(corsDevPolicy);
}
else
{
    app.UseCors(corsPolicy);
    
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();