var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();
//request pipeline
//authentication
//routing
//controlllerviewlar
//authorization
//razor
//rest api

// url/controller/action/id?

// app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern:"{controller=Home}/{action=Index}/{id?}" 
);
app.Run();
