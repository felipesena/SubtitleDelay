using System;
using System.Runtime.Serialization;

namespace Legenda
{
    [Serializable]
    internal class DelayMinimoException : Exception
    {
        public DelayMinimoException()
        {
        }

        public DelayMinimoException(string message) : base(message)
        {
        }

        public DelayMinimoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DelayMinimoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}