var builder = WebApplication.CreateBuilder(args);//.Host.ConfigureHostConfiguration(host =>
// {
//     host.AddJsonFile("appsettings.json");
// });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();