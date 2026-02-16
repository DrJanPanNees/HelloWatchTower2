var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from CI/CD Pipeline!");
app.MapGet("/", () => "🚀 CI/CD VIRKER! Opdateret kl. " + DateTime.Now.ToLongTimeString());
app.MapGet("/healthz", () => Results.Ok("Healthy")); 

app.MapGet("/", () => "Hello World!");
app.MapGet("/", () => "Jan Pan Nees!");

app.Run();
