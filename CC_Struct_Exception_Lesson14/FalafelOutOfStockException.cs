using System.Runtime.Serialization;

namespace CC_Struct_Exception_Lesson14
{
    [Serializable]
    internal class FalafelOutOfStockException : ApplicationException
    {
        public FalafelOutOfStockException()
        {
        }

        public FalafelOutOfStockException(string? message) : base(message)
        {
        }

        public FalafelOutOfStockException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FalafelOutOfStockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}