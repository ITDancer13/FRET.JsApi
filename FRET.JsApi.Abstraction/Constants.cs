using FRET.JsApi.Abstraction.Interfaces;
using FRET.JsApi.Abstraction.Models;

namespace FRET.JsApi.Abstraction;

/// <summary>
/// Constants used in JS-API e.g. for events or bound objects.
/// </summary>
public static class Constants
{
    /// <summary>
    /// Object name of the first player in FRET.
    /// Used interface of this object: <see cref="IPlayerAdaptor"/>.
    /// </summary>
    /// <remarks>
    /// Call `await CefSharp.BindObjectAsync("fretPlayer1")` to bind.
    /// </remarks>
    public const string Player1JsName = "fretPlayer1";

    /// <summary>
    /// Object name of the second player in FRET.
    /// Used interface of this object: <see cref="IPlayerAdaptor"/>.
    /// </summary>
    /// <remarks>
    /// Call `await CefSharp.BindObjectAsync("fretPlayer2")` to bind.
    /// </remarks>
    public const string Player2JsName = "fretPlayer2";

    /// <summary>
    /// Object name of the login manager in FRET.
    /// Used interface of this object: <see cref="ILoginManagerAdaptor"/>.
    /// </summary>
    /// <remarks>
    /// Call `await CefSharp.BindObjectAsync("fretPlayer1")` to bind.
    /// </remarks>
    public const string LoginManager = "fretLoginManager";
    
    /// <summary>
    /// Object name of the login manager in FRET.
    /// Used interface of this object: <see cref="IFretEnvironmentAdaptor"/>.
    /// </summary>
    /// <remarks>
    /// Call `await CefSharp.BindObjectAsync("fretEnvironment")` to bind.
    /// </remarks>
    public const string Environment = "fretEnvironment";

    /// <summary>
    /// Name of the event which is sent whenever the status of a player has been changed.
    /// Used model of this event: <see cref="PlayerState"/>.
    /// </summary>
    /// <remarks>
    /// fretPlayer1StateChanged and fretPlayer2StateChanged will be the actual names.
    /// </remarks>
    public const string PlayerStateChangedEventName = "fretPlayer{0}StateChanged";

    /// <summary>
    /// Name of the event which is sent whenever the user in FRET has been logged out.
    /// </summary>
    public const string UserLoggedOutEventName = "fretUserLoggedOut";
}
