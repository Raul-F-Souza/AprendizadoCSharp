using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Seja bem vindo ao nosso sistema interno!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta ou login incorreto!");
                return false;
            }
        }
    }
}
