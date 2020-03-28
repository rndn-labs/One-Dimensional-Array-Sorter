using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_dimensional_array
{
    class Funcs
    {
      public static int[] Sort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int z = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = z;
                    }
                }
            }
            return A;
        }
    }
}
