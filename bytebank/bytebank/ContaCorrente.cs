using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public double saldo = 100;
        public string conta;

        public string titular;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente Destino)
        {
            if (this.saldo > valor && valor > 0)
            {
                this.Sacar(valor);
                Destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
