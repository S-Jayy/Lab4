var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    name: "Account",
    pattern: "Account/{action=Index}/{id?}",
    defaults: new { controller = "Account" });

// Add a new route for the "Add" action in the "Account" controller
app.MapControllerRoute(
    name: "Add",
    pattern: "Account/Add",
    defaults: new { controller = "Account", action = "Add" });

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    defaults: new { controller = "Home" });

app.Run();
