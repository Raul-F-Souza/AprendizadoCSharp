using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Conta
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        private int Numero_agencia { get; set; }
        public string Conta { get; set; }
        public Cliente Titular { get; set; }
        private double saldo = 100;

        //Inicio dos metodos
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente Destino)
        {
            if (saldo > valor && valor > 0)
            {
                Sacar(valor);
                Destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
            else
            {
                return;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        //Fim dos metodos

        public ContaCorrente(int numero_agencia, string numero_conta, double saldo, Cliente titular)
        {
            this.Titular = titular;
            this.saldo = saldo;
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }
    }
}
