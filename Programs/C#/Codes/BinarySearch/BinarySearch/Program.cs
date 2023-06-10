namespace BinarySearch
{
    class Program
    {
        static int binarySearch(int[] arr, int num)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == num)
                    return mid;

                if (arr[mid] < num)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {

        }
    }
}
