using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {

        public string Senha { get; protected set; }
        public string Login { get; protected set; }
        public bool Autenticar(string login, string senha);
    }
}
