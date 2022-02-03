using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_de_Repeticao
{
    //Classe para a construção dos laço que imprimirá os Números Primos de 0 a 1000.
    internal class Números_Primos
    {
        public int i;

        public void Laco_for()
        {
            Console.WriteLine("Números Primos de 1 a 100....");
            for (i = 1; i <= 100; i++)
            {
                int cont = 0;

                for (int n = i; n > 0; n--)
                {
                    if (i % n == 0)
                    {
                        cont++;
                    }
                    if (cont > 2)
                    {
                        break;
                    }
                    /*condição sempre será verdadeira quando chegar em 2 divisões, não finalizando o 2º for 
                    if (cont == 2)
                    {
                        Console.WriteLine(i);
                    }*/
                    
                }
            if (cont == 2)
            {
                Console.WriteLine(i);
            }
            
        }
        Console.ReadKey();
        }
    }
}
