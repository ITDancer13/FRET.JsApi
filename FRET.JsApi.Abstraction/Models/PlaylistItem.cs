using System;

namespace FRET.JsApi.Abstraction.Models;

public class PlaylistItem
{
    /// <summary>
    /// Unique id of the song.
    /// </summary>
    public Guid SongId { get; set; }

    /// <summary>
    /// Artist of the song.
    /// </summary>
    public string Artist { get; set; }

    /// <summary>
    /// Title of the song.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Dances linked to the song.
    /// </summary>
    public string Dances { get; set; }

    /// <summary>
    /// Length (in seconds) of the song.
    /// </summary>
    public double LengthSec { get; set; }
}