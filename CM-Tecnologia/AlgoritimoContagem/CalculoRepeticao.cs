namespace CM_Tecnologia
{
    public class CalculoRepeticao
    {
        public static int CalculoNumeros()
        {
            int[] numArray = { 10, 10, 10, 20, 5, 5, 9 };
            int[] numeros = new int[5];
            int repeticao = 0;
            int repeticaoPadrao = 0;

            foreach (var num in numArray)
            {
                for (var i = 0; i < numArray.Length; i++)
                {
                    if (num == numArray[i])
                    {
                        repeticao++;
                    }

                    if (repeticao > repeticaoPadrao)
                    {
                        repeticaoPadrao = repeticao;
                        numeros[i] = numArray[i];
                    }
                }
            }

            return repeticaoPadrao;
        }
    }
}