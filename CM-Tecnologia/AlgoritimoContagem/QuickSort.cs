namespace CM_Tecnologia
{
    public class QuickSort
    {
        public static void Quicksort(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                    i++;

                while (numbers[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort(numbers, left, j);

            if (i < right)
                Quicksort(numbers, i, right);
        }
    }
}