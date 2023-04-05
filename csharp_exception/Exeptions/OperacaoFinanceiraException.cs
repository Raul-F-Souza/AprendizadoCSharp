using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Exeptions
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string menssagem) : base(menssagem)
        {

        }
        public OperacaoFinanceiraException(string menssagem, Exception excecaoInterna) : base(menssagem, excecaoInterna)
        {

        }
    }
}
