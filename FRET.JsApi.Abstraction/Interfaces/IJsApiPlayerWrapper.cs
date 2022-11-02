using System.Threading.Tasks;
using FRET.JsApi.Abstraction.Models;

namespace FRET.JsApi.Abstraction.Interfaces;

/// <summary>
/// Interface of a FRET player.
/// </summary>
public interface IJsApiPlayerWrapper
{
    /// <summary>
    /// Plays the given song on this player.
    /// </summary>
    /// <param name="songId">ID of the song. Must be in parsable GUID foramt.</param>
    /// <param name="force">Forces to play even if another song is currently playing.</param>
    Task<JsApiCallResult> Play(string songId, bool force = false);

    /// <summary>
    /// Pauses or unpauses the player.
    /// </summary>
    Task<JsApiCallResult> Pause();

    /// <summary>
    /// Stops the player.
    /// </summary>
    Task<JsApiCallResult> Stop();
}