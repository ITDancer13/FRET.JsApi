using System.Threading.Tasks;
using FRET.JsApi.Abstraction.Models;

namespace FRET.JsApi.Abstraction.Interfaces;

/// <summary>
/// Interface of FRET login manager.
/// </summary>
public interface IJsApiLoginManagerWrapper
{
    /// <summary>
    /// Signalized that the given external user was logged in.
    /// FRET tries to map this user id to an internal user to login.
    /// </summary>
    Task<JsApiCallResult> Login(int externalUserId);
    
    /// <summary>
    /// Sigalizes that the logged in user was logged out.
    /// FRET logsout the user as well.
    /// </summary>
    Task<JsApiCallResult> Logout();
}
