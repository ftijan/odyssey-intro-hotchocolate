using SpotifyWeb;

namespace Odyssey.MusicMatcher;

public class Query
{
	// where Query resolver functions will go		

	[GraphQLDescription("Playlists hand-picked to be featured to all users.")]
	public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
	{
		var response = await spotifyService.GetFeaturedPlaylistsAsync();			

		return [.. response.Playlists.Items.Select(item => new Playlist(item))];
	}

	[GraphQLDescription("Retrieves a specific playlist.")]
	public async Task<Playlist?> GetPlaylist([ID] string id, SpotifyService spotifyService)
	{
		var response = await spotifyService.GetPlaylistAsync(id);

		return new Playlist(response);
	}
}
