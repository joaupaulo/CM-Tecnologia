using System;
using CM_Tecnologia.FigurasGeometricas;
using CM_Tecnologia.Opcao;

namespace CM_Tecnologia
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int menu = 0;
            var numbers = new[] { 1, 5, 0, 34, 3, 9 };

            Console.WriteLine("----------------- BEM VINDO AOS TESTES - CM TECNOLOGIA ---------------------");
            Console.WriteLine("----------------- DIGITE 1 - PARA CALCULAR A MODA DE UM VETOR -------------");
            Console.WriteLine(" ----------------- DIGITE 2 - PARA ORDENAR UM VETOR-----------------");
            Console.WriteLine("------------------ DIGITE 3 - UTILIZAR A PILHA----------------");
            Console.WriteLine("------------------ DIGITE 4 - PARA CALCULAR AS FIGURAS GEOMETRICA -----------");
            Console.WriteLine("------------------ Entre na PASTA DOMINIOS PARA VERIFICAR OS DOMINIOS-----------");

            menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (menu)
            {
                 
                case 1:
                    {
                        CalculoRepeticao.CalculoNum();
                        break;
                    }

                case 2:
                    {
                        QuickSort.Quicksort(numbers,4 , 5);
                        break;
                    }

                case 3:
                    {
                        Pilha.Pilha.PilhaStack();
                        break;
                    }

                case 4:
                    {
                        OpcoesMenu escolha = OpcoesMenu.Quadradro;
                        while ((escolha = GetEscolha()) != OpcoesMenu.Sair)
                        {
                            Console.Clear();
                            CalcularArea calcular = null;

                            switch (escolha)
                            {
                                case OpcoesMenu.Quadradro:
                                    {
                                        calcular = CalcularQuadrado();
                                        break;
                                    }
                                case OpcoesMenu.Circulo:
                                    {
                                        calcular = CalcularCirculo();
                                        break;
                                    }
                                case OpcoesMenu.TriangoEquilatero:
                                    {
                                        calcular = CalcularTrianguloEq();
                                        break;
                                    }
                            }
                            Console.WriteLine($"---------------------- A área do {escolha} é {calcular.calculaArea}-------------------");
                        }
                        Environment.Exit(0);
                        break;
                    }
            }
        }

        public static OpcoesMenu GetEscolha()
        {
            Console.WriteLine("Vamos calcular a área ? ");
            Console.WriteLine("---------------- Para calcular a área do Quadrado digite 1 ------------", (int)OpcoesMenu.Quadradro);
            Console.WriteLine("------------ Para calcular o raio da circufenrencia do Circulo digite 2---------- ", (int)OpcoesMenu.Circulo);
            Console.WriteLine(" -----------Para calcular a área do Triangulo Equilatero digite 3 -----------", (int)OpcoesMenu.TriangoEquilatero);
            Console.WriteLine(" Digite 0 Para sair", (int)OpcoesMenu.Sair);
            string valor = Console.ReadLine();
            OpcoesMenu escolha;

            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(OpcoesMenu), escolha))
            {
                Console.WriteLine("Opção Invalida");
                return OpcoesMenu.Sair;
            }
            return escolha;
        }

        private static double GetDouble(string prompt)
        {
            bool Valido = false;
            double valor = 0;

            while (!Valido)
            {
                Console.Write(prompt);
                Valido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }

        private static Quadrado CalcularQuadrado()
        {
            double Lado = GetDouble("Lado do quadrado : ");
            return new Quadrado() { lado = Lado };
        }

        private static Circulo CalcularCirculo()
        {
            double Raio = GetDouble("Raio do circulo : ");
            return new Circulo() { raio = Raio };
        }

        private static TrianguloEquilatero CalcularTrianguloEq()
        {
            double Base = GetDouble("Base Do Triangulo : ");
            double Altura = GetDouble("Altura Do Triangulo: ");

            return new TrianguloEquilatero() { Base = Base, Altura = Altura };
        }
    }
}