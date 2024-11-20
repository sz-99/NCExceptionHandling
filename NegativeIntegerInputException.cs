using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NegativeIntegerInputException : Exception
    {
        //public override string Message { get; }
        //public NegativeIntegerInputException(string message )
        //{
        //    Message = message;

        //}
        public NegativeIntegerInputException()
        {
        }

        public NegativeIntegerInputException(string? message) : base(message)
        {
        }

        public NegativeIntegerInputException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NegativeIntegerInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
