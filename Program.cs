using Microsoft.EntityFrameworkCore;
using Social_App.Models;
using Social_App.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    string key = File.ReadAllText(builder.Configuration.GetSection("SecurityOptions:Public_Key").Value!);
    var pem = "-----BEGIN PUBLIC KEY-----\n" + key + "\n-----END PUBLIC KEY-----";
    var rsa = new RSACryptoServiceProvider();
    rsa.ImportFromPem(pem);

    options.TokenValidationParameters = new TokenValidationParameters
    {
        // For some reason .Net denies Issuer when we declare in appsetting
        // So we have to declare it here
        ValidIssuers = new List<string>() {
            "https://darling-hound-1.clerk.accounts.dev",
        },
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true, 
        ValidateAudience = false, // Clerk JWT doesn't have this
        IssuerSigningKey = new RsaSecurityKey(rsa)
    };
});
builder.Services.AddAuthorization();
builder.Services.AddControllers();

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseDefaultFiles();
    app.UseStaticFiles();
}


app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();