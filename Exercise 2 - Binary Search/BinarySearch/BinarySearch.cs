namespace BinarySearch
{
    public class BinarySearch
    {
        public int? Find( int[] array, int value )
        {
            if (array.Length == 0)
                return null;

            var lower = 0;
            var upper = array.Length - 1;

            while (lower != upper)
            {
                var pivot = (lower + upper) / 2;
                var pivotValue = array[pivot];

                if (pivotValue < value)
                    lower = pivot;
                else
                    upper = pivot;
            }

            return array[lower] == value ? lower : (int?)null;
        }
    }
}
