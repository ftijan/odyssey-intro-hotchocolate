using Odyssey.MusicMatcher;
using SpotifyWeb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<SpotifyService>();
builder.Services.AddScoped<SpotifyService>();

builder.Services.AddGraphQLServer()
	.AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
