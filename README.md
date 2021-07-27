# CodilityCyclicRotation

## Codility Cyclic Rotation
###The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

Write a function:

class Solution { public int[] solution(int[] A, int K); }

that, given an array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given

    A = [3, 8, 9, 7, 6]
    K = 3
the function should return [9, 7, 6, 3, 8].

```csharp
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
