using System;
using DesafioFixaxao;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desafio
     * A propriedade Matricula precisa validar a operação de Set, não permitindo a inserção de valores menores ou iguais a zero.
Como Pedro poderia resolver o problema?
    */

namespace DesafioFixaxao.DesafioProps
{

    public class MatriculaPedro
    {
        private int matricula;
        public int Matricula
        {
            get 
            {
                return matricula; 
            }
            set
            {
                if (value <= 0) { return; };
            }
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }

    }
}
