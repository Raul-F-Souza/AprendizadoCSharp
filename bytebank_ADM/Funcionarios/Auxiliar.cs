using bytebank_ADM.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario, IBonificacao
    {
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000)
        { }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
