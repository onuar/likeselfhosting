namespace likeselfhosting
{
    public class InvalidUrlException : System.Exception
    {
        public InvalidUrlException() { }
        public InvalidUrlException( string message ) : base( message ) { }
        public InvalidUrlException( string message, System.Exception inner ) : base( message, inner ) { }
    }
}