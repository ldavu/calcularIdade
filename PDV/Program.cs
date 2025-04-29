using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantidadeProduto = 12;

            // Console.WriteLine(quantidadeProduto);
            quantidadeProduto++;
            //Console.WriteLine(quantidadeProduto);

            long quantidadeProduto2 = (long)quantidadeProduto;
            byte quantidadeProduto3 = (byte)quantidadeProduto;

            double valorunitario = quantidadeProduto/4;
            Console.WriteLine(valorunitario);
        }
    }
}
