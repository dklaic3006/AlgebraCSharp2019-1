using System;
using System.Runtime.Serialization;

namespace _1_ucenik_drugi_nacin
{
    [Serializable]
    internal class Exception_negativan_broj : Exception
    {
        public Exception_negativan_broj()
        {
        }

        public Exception_negativan_broj(string message) : base(message)
        {
           Console.WriteLine("Greška unesen je negativan broj");
        }

        public Exception_negativan_broj(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Exception_negativan_broj(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}