using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace testePratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolhaInicial;

            Console.WriteLine("[1] - Criar/inserir Arquivos");
            Console.WriteLine("[2] - Vizualizar linhas");
            Console.WriteLine("[3] - Localização do Arquivo");
            escolhaInicial = int.Parse(Console.ReadLine());

                     
                switch (escolhaInicial)
                {
                    case 1:
                        Console.WriteLine("A opção 1 foi escolhida, em 2 segundos você sera direcionado");
                        System.Threading.Thread.Sleep(2000);
                        funcao1();
                        break;

                    case 2:
                        Console.WriteLine("A opção 2 foi escolhida, em 3 segundos você sera direcionado");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case 3:
                        Console.WriteLine("A opção 3 foi escolhida, em 3 segundos você sera direcionado");
                        System.Threading.Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine("A opção escolhida é invalida, tente novamente em 3s\n");
                        System.Threading.Thread.Sleep(2000);
                    break;

            }
            

            
        }
        
        static void funcao1()
        {
            Console.WriteLine("teste");
            Console.ReadKey();
        }

        static void funcao2()
        {
            
        }

        static void funcao3()
        {

        }


    }

}






