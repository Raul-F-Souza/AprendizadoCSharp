using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel, IBonificacao
    {

        public GerenteDeContas(string nome, string cpf, string login, string senha) : base(nome, cpf, 4000, login, senha)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
