using Authentication.ClientAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapPost("login", AuthenticationEndpoints.LogIn);
app.MapPost("logout", AuthenticationEndpoints.LogOut);

await app.RunAsync();
