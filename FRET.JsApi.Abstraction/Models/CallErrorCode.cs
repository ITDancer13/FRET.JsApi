namespace FRET.JsApi.Abstraction.Models;

/// <summary>
/// Enumeration of all possible technical error codes used in <see cref="JsApiCallResult"/>.
/// </summary>
public enum JsApiCallErrorCode
{
    /// <summary>
    /// No error occurred. 
    /// Call was successful.
    /// </summary>
    None,

    /// <summary>
    /// Login failed. 
    /// No specific error defails available.
    /// </summary>
    LoginGenericError,

    /// <summary>
    /// Logout failed.
    /// There is no logged in user at the moment.
    /// </summary>
    LogoutNoUserLoggedIn,

    /// <summary>
    /// Generic error.
    /// Provided song id is invalid. Ensure that it's provided in valid GUID format.
    /// </summary>
    SongIdInvalidFormat,

    /// <summary>
    /// Song not found.
    /// There is no active song with this id in the database.
    /// </summary>
    /// <remarks>
    /// It might become available soon (e.g. if the cache is not loaded after startup).
    /// </remarks>
    SongNotFound,

    /// <summary>
    /// Song not loaded.
    /// Song could not be loaded from the server or to the player.
    /// </summary>
    SongNotLoaded,

    /// <summary>
    /// Player action not possible.
    /// Player is in a invalid state. Use force-flag to force this action.
    /// </summary>
    PlayerInvalidState,

    /// <summary>
    /// Player action not possible.
    /// Player is in an unknown state.
    /// </summary>
    PlayerUnknownState,
}