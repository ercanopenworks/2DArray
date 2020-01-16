using System;
using System.Text;

namespace _2dArray
{
    class Program
    {
        static int hourglassSum(int[][] arr)
        {


            int maxsum = Int32.MinValue, jj = 0;
            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = jj; j < jj + 3; j++)
                {
                    sum += arr[i][j];
                    if (j == jj) sum += arr[i + 1][jj + 1];
                    sum += arr[i + 2][j];
                }
                jj = (jj < 3) ? jj + 1 : 0;
                if (sum > maxsum) maxsum = sum;
                if (jj != 0) i--;
            }

            return maxsum;


        }
        static void Main(string[] args)
        {

            int[][] arr = new int[6][];

            string[] str= new string[6];

            str[0] = "1 1 1 0 0 0";
            str[1] = "0 1 0 0 0 0";
            str[2] = "1 1 1 0 0 0";
            str[3] = "0 0 2 4 4 0";
            str[4] = "0 0 0 2 0 0";
            str[5] = "0 0 1 2 4 0";


            for (int i = 0; i < 6; i++)
            {
                //arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                arr[i] = Array.ConvertAll(str[i].ToString().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine("Result : " + result.ToString());
            Console.ReadKey();
        }
    }
}
