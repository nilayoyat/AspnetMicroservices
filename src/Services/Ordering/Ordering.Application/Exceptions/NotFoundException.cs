namespace Ordering.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key)
        : base($"entity \"{name}\" \"{key}\" not found")
        { }
    }
}
