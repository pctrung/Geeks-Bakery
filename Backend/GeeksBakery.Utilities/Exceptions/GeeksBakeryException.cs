using System;

namespace GeeksBakery.Utilities.Exceptions
{
    public class GeeksBakeryException : Exception
    {
        public GeeksBakeryException()
        {
        }

        public GeeksBakeryException(string message)
            : base(message)
        {
        }

        public GeeksBakeryException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}