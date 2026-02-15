var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from CI/CD Pipeline!");
app.MapGet("/healthz", () => Results.Ok("Healthy")); 

app.MapGet("/", () => "Hello World!");

app.Run();
