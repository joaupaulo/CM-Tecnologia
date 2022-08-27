using System.Collections;
using System.Collections.Generic;

namespace CM_Tecnologia.Pilha
{
    public class Pilha
    {
        public static void PilhaStack()
        {
            Stack<string> Pilha = new Stack<string>();

            Pilha.Push("Vitoria");
            Pilha.Push("Bahia");
            Pilha.Push("Flamengo");
            Pilha.Push("Corinthias");
            Pilha.Push("CM-TECNOLOGIA");

            Pilha.Pop();
        }
    }
}