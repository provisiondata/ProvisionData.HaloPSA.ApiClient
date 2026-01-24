namespace ProvisionData.HaloPSA.ApiClient.Models;

public class HaloApiException : Exception
{
    public HaloApiException(String? message) : base(message)
    {
    }

    public HaloApiException(String? message, String? json = null) : base(message)
    {
        JSON = json ?? String.Empty;
    }

    public HaloApiException(String? message, Exception? innerException) : base(message, innerException)
    {
    }

    public HaloApiException(String? message, String? json = null, Exception? innerException = null) : base(message, innerException)
    {
        JSON = json ?? String.Empty;
    }

    internal HaloApiException() : base()
    {
    }

    public String JSON { get; internal set; } = String.Empty;
}
