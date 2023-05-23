using HttpClientCrud.Models.ViewModel;
using Microsoft.Extensions.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<IHttpCrud, HttpCRUD>();
//builder.Services.AddScoped(typeof(IHttpCrud<>), typeof(HttpCRUD<>));

//builder.Services.Configure<HttpClientFactoryOptions>(options =>
//{
//    options.HttpClientActions.Add(client =>
//    {
//        client.BaseAddress = new Uri("https://localhost:44397/api/");
//        client.DefaultRequestHeaders.Add("Accept", "application/json");
//    });
//});

//builder.Services.AddHttpClient<IHttpCrud, HttpCRUD>(client =>
//{
//    //client.BaseAddress = new Uri("http://localhost:5000/api/actor");
//    client.DefaultRequestHeaders.Add("Accept", "application/json");
//});

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
