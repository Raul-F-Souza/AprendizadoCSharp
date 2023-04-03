using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {

        public string Senha { get; set; }
        public string Login { get; set; }
        protected FuncionarioAutenticavel(string nome, string cpf, double salario, string login, string senha) : base(nome, cpf, salario)
        {
            this.Senha = senha;
            this.Login = login;
        }


        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;
        }
    }
}
