using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_Tecnologia
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            var numbers = new[] { 1, 5, 0, 34, 3, 9 };

           
                Console.WriteLine(" BEM VINDO AOS TESTES - CM TECNOLOGIA");
                Console.WriteLine(" DIGITE 1 - PARA CALCULAR A MODA DE UM VETOR");
                Console.WriteLine(" DIGITE 2 - PARA ORDENAR UM VETOR");
                Console.WriteLine("DIGITE 3 - UTILIZAR A PILHA");
                Console.WriteLine("Entre na PASTA DOMINIOS PARA VERIFICAR OS DOMINIOS");
               
            

             menu = Convert.ToInt32(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    {
                        CalculoRepeticao.CalculoNumeros();
                        break;
                    }

                case 2:
                    {
                        QuickSort.Quicksort(numbers,3,9);
                        break;
                    }

                case 3:
                    {
                        Pilha.Pilha.PilhaStack();
                        break;
                    }

            }

        }
    }
}
