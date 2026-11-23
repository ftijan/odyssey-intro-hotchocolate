using Odyssey.MusicMatcher;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
	.AddQueryType<Query>()
	.AddType<Playlist>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
