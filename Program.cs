using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
	app.MapScalarApiReference();
}

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

app.Run();
