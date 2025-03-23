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
    
    public class UltimaCidadeRegiaoException : RegiaoException
    {
        public UltimaCidadeRegiaoException(string regiaoNome) 
            : base($"A regiÃo {regiaoNome} deve possuir pelo menos uma cidade") { }
    }
} 