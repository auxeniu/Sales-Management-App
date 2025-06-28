using System;

namespace ProiectVanzari.Clase.Exceptii
{
    public class ValidareException : Exception
    {
        public ValidareException(string message) : base(message) { }
    }
}