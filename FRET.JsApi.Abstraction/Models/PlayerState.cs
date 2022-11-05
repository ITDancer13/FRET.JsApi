using System;

namespace FRET.JsApi.Abstraction.Models;

/// <summary>
/// Representation of a player state.
/// </summary>
public class PlayerState
{
    /// <summary>
    /// Internal state of the player.
    /// </summary>
    public string State { get; set; } = "NotInitialized";

    /// <summary>
    /// Id of the song loaded to the player.
    /// </summary>
    /// <remarks>
    /// Will be null, if player is empty.
    /// </remarks>
    public Guid? SongId { get; set; }

    /// <summary>
    /// Artist of the song loaded to the player.
    /// </summary>
    /// <remarks>
    /// Will be null, if player is empty.
    /// </remarks>
    public string Artist { get; set; }

    /// <summary>
    /// Title of the song loaded to the player.
    /// </summary>
    /// <remarks>
    /// Will be null, if player is empty.
    /// </remarks>
    public string Title { get; set; }

    /// <summary>
    /// Length (in seconds) of the song loaded to the player.
    /// </summary>
    /// <remarks>
    /// Will be null, if player is empty.
    /// </remarks>
    public double? LengthSec { get; set; }

    /// <summary>
    /// Current play position.
    /// </summary>
    /// <remarks>
    /// Will be null, if player is empty.
    /// </remarks>
    public double? PositionSec { get; set; }
}
