using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Resgistar (Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}
