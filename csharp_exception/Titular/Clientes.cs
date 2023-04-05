using csharp_exception.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Profissao = profissao;

        }
    }
}
