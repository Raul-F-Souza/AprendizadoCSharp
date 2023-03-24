using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desafio:  O cliente informou a necessidade de cadastrar informações sobre o nome, fabricante, código de barras, valor unitário,
valor de compra e quantidade em estoque de determinado produto. */

namespace bytebank
{
    public class ProdutoMercado
    { 
        public double valorUnitario;
        public double valorDeCompra;
        public double quantidadeEmEstoque;
        public string codigoDeBarras;
        public string nome;
        public string fabricante;
    }

}