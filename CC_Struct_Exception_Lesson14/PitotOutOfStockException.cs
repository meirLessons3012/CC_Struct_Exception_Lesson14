using System.Runtime.Serialization;

namespace CC_Struct_Exception_Lesson14
{
    [Serializable]
    internal class PitotOutOfStockException : Exception
    {
        public PitotOutOfStockException()
        {
        }

        public PitotOutOfStockException(string? message) : base(message)
        {
        }

        public PitotOutOfStockException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PitotOutOfStockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}