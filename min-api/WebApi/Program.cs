var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/check", () => {
return "Minimal API Version 1.1";
});

app.Run();
