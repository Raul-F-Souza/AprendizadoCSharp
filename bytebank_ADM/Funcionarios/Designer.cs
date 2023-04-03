using bytebank_ADM.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario, IBonificacao
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
