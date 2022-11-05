using System.Threading.Tasks;
using FRET.JsApi.Abstraction.Models;

namespace FRET.JsApi.Abstraction.Interfaces;

/// <summary>
/// Interface of FRET login manager.
/// </summary>
public interface ILoginManagerAdaptor
{
    /// <summary>
    /// Signalized that the given external user was logged in.
    /// FRET tries to map this user id to an internal user to login.
    /// </summary>
    Task<CallResult> Login(int externalUserId);
    
    /// <summary>
    /// Signalizes that the logged in user was logged out.
    /// FRET logout the user as well.
    /// </summary>
    Task<CallResult> Logout();
}
