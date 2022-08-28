namespace CM_Tecnologia
{
    public class QuickSort
    {
        public static void Quicksort(int[] numArray, int nEsquerdo, int nDireito)
        {
            int i = nEsquerdo;
            int j = nDireito;

            var fixo = numArray[(nEsquerdo + nDireito) / 2];

            while (i <= j)
            {
                while (numArray[i] < fixo)
                    i++;

                while (numArray[j] > fixo)
                    j--;

                if (i <= j)
                {
                    var tempor = numArray[i];
                    numArray[i] = numArray[j];
                    numArray[j] = tempor;

                    i++;
                    j--;
                }
            }

            if (nEsquerdo < j)
                Quicksort(numArray, nEsquerdo, j);

            if (i < nDireito)
                Quicksort(numArray, i, nDireito);
        }
    }
}