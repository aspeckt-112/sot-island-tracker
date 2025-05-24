using SotIslandTracker.Web.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDatabase(builder.Configuration)
    .AddAspNetIdentity()
    .AddRazorPages();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await app.MigrateDatabase();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection()
    .UseRouting()
    .UseAuthentication()
    .UseAuthorization();

app.MapStaticAssets();

app.MapRazorPages()
    .WithStaticAssets();

await app.RunAsync();