namespace CM_Tecnologia
{
    public class CalculoRepeticao
    {
        public static int CalculoNum()
        {
            int[] numArray = { 10, 10, 10, 20, 5, 5, 9 };
            int repeticao = 0;
            int moda = 0;
            int comparar = 0;

            for (var i = 0; i < numArray.Length; i++)
            {
                repeticao = 0;

                for (var j = i + 1; j < numArray.Length; j++)
                {
                    if (numArray[i] == numArray[j])
                    {
                        repeticao++;
                    }
                }

                if (repeticao > comparar)
                {
                    moda = numArray[i];
                    comparar = repeticao;
                }
            }

            return moda;
        }
    }
}