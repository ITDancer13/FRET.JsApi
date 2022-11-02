namespace FRET.JsApi.Abstraction.Models;

/// <summary>
/// Result model which is used for all calls as e.g. Exception handling is unconvenient at this point.
/// </summary>
public class JsApiCallResult
{
    /// <summary>
    /// Indictates if the call was successful.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Technical error code if the call was not successful.
    /// </summary>
    public JsApiCallErrorCode ErrorCode { get; }

    /// <summary>
    /// Human readable error message if the call was not successful.
    /// </summary>
    public string ErrorMessage { get; }
      
    /// <summary>
    /// Public constructor to create a non-success instance.
    /// </summary>
    public JsApiCallResult(JsApiCallErrorCode errorCode, string errorMessage)
    {
        IsSuccess = false;
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }

    /// <summary>
    /// Private constructor to create success instance.
    /// </summary>
    private JsApiCallResult()
    {
        IsSuccess = true;
        ErrorCode = JsApiCallErrorCode.None;
        ErrorMessage = string.Empty;
    }

    /// <summary>
    /// Default success instance.
    /// </summary>
    internal static JsApiCallResult Success { get; } = new();
}
