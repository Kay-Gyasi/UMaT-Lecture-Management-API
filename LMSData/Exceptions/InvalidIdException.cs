namespace LMSData.Exceptions;

public class InvalidIdException : Exception
{
    public InvalidIdException()
    {
    }
    
    public InvalidIdException(string message) : base(message)
    {
        
    }
}

public class RepositoryNotFoundException : Exception
{
    public RepositoryNotFoundException()
    {
    }
    
    public RepositoryNotFoundException(string message) : base(message)
    {
        
    }
}
