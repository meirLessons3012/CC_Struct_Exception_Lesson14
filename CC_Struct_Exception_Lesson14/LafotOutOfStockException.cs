using System.Runtime.Serialization;

namespace CC_Struct_Exception_Lesson14
{
    [Serializable]
    internal class LafotOutOfStockException : Exception
    {
        public LafotOutOfStockException()
        {
        }

        public LafotOutOfStockException(string? message) : base(message)
        {
        }

        public LafotOutOfStockException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LafotOutOfStockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}