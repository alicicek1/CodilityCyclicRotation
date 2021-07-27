using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 8, 9, 7, 6 };
            ArrayRotation.Rotate(arr, 3);
        }
    }

    public static class ArrayRotation
    {
        public static int[] Rotate(int[] A, int K)
        {
            if (A.Length == K)
                return A;


            int[] temp = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                temp[i] = A[i];
            }

            var res = temp;
            for (int i = 0; i < A.Length; i++)
            {
                if ((i + K) < A.Length)
                {
                    res[i + K] = A[i];
                }
                else if ((i + K) > A.Length)
                {
                    res[((i + K) % A.Length)] = A[i];
                }
                else if (((i + K) % A.Length) == 0)
                    res[0] = A[i];
            }
            return res;
        }
    }
}
