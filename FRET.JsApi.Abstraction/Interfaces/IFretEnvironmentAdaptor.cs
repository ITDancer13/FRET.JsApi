using System.Threading.Tasks;
using FRET.JsApi.Abstraction.Models;

namespace FRET.JsApi.Abstraction.Interfaces;

/// <summary>
/// Interface to access information about FRET Hosting Environment.
/// </summary>
public interface IFretEnvironmentWrapper
{
    /// <summary>
    /// Provides information about FRET Hosting Environment.
    /// </summary>
    Task<FretEnvironmentInfo> GetFretEnvironmentInfo();
}