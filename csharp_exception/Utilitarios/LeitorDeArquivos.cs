using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Utilitarios
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            // throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public static void CarregarContas()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

            try 
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch(IOException ex)
            {
                Console.WriteLine("Exceção do tipo IOException encontrada e tratada.");
            }
            finally
            {
                leitor.Dispose();
            }
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            throw new IOException();

            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
