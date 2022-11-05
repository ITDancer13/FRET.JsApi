namespace FRET.JsApi.Abstraction.Models;

/// <summary>
/// Result model which is used for all calls as e.g. Exception handling is inconvenient at this point.
/// </summary>
public class CallResult
{
    /// <summary>
    /// Indicates if the call was successful.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Technical error code if the call was not successful.
    /// </summary>
    public CallErrorCode ErrorCode { get; }

    /// <summary>
    /// Human readable error message if the call was not successful.
    /// </summary>
    public string ErrorMessage { get; }
      
    /// <summary>
    /// Public constructor to create a non-success instance.
    /// </summary>
    public CallResult(CallErrorCode errorCode, string errorMessage)
    {
        IsSuccess = false;
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
    }

    /// <summary>
    /// Private constructor to create success instance.
    /// </summary>
    private CallResult()
    {
        IsSuccess = true;
        ErrorCode = CallErrorCode.None;
        ErrorMessage = string.Empty;
    }

    /// <summary>
    /// Default success instance.
    /// </summary>
    public static CallResult Success { get; } = new();
}
