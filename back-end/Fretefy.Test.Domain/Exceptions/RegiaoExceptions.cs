using System;

namespace Fretefy.Test.Domain.Exceptions
{
    public class RegiaoException : Exception
    {
        public RegiaoException(string message) : base(message) { }
    }

    public class RegiaoNomeJaExisteException : RegiaoException
    {
        public RegiaoNomeJaExisteException(string nome) 
            : base($"Já existe uma região com o nome '{nome}'") { }
    }
} 