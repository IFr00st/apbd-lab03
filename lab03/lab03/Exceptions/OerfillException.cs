namespace lab03.Exceptions;

public class OerfillException : Exception
{
    public OerfillException()
    {
    }

    public OerfillException(string? message) : base(message)
    {
    }

    public OerfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}