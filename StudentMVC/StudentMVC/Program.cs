using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentMVC.Mapping;
using StudentMVC.Service.Abstract;
using StudentMVC.Service.Impliment;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using StudentMVC.Models.Entity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StudentMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentMVCDB") ?? throw new InvalidOperationException("Connection string 'StudentMVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

builder.Services.AddCors(options =>
    options.AddPolicy("MyPolicy", builder =>
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
    )
);

builder.Services.AddHttpClient();

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<StudentMVCContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
