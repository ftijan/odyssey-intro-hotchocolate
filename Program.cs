using Odyssey.MusicMatcher;
using SpotifyWeb;

var builder = WebApplication.CreateBuilder(args);

// Use this DI pattern with the newer HotChocolate versions:
builder.Services.AddHttpClient<SpotifyService>();
builder.Services.AddScoped<SpotifyService>();

builder.Services.AddGraphQLServer()
	.AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
