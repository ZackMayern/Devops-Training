var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // serves index.html automatically at "/"
app.UseStaticFiles();    // serves files from wwwroot/

app.Run();