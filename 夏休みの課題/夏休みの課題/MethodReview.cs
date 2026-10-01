using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 夏休みの課題
{
    //
    internal class MethodReview
    {
        private static void Main(string[] args)
        {
            /*

            //問題１
            Console.WriteLine("問題１");

            CallSekiTeacher();

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, Addition(num1, num2));

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題３");

            int[] array = new int[] { 5, 7, 12, 9, 15, 8, 23, 4, 10 };

            Console.WriteLine("配列の最小値は{0}です。", GetArrayMinNumber(array));

            Console.WriteLine("配列の最大値は{0}です。", GetArrayMaxNumber(array));

            */

            //問題４
            //Console.WriteLine("問題４");

            //int[] array = new int[] { 5, 7, 12, 9, 15, 8, 23, 4, 10 };

            //int[] evenArray = GetEvenNumberList(array);

            //evenArray配列の最後まで繰り返す
            //foreach(int i in evenArray)
            //{
                //Console.WriteLine(i);
            //}
        }

        private static void CallSekiTeacher()
        {
            Console.WriteLine("関先生！");
        }

        private static int Addition(int num1,int num2)
        {
            //num1とnum2を足す
            return num1 + num2;
        }

        private static int GetArrayMinNumber(int[] array)
        {
            //最小値
            int minnumber = array[0];

            //配列の最後に到達するまで繰り返す、また１から始まるのは０番目の配列が標準値となっているため
            for (int i = 1; i <= array.Length -1; i++)
            {
                //もし最小値が配列の数よりも大きいのなら
                if (array[i] < minnumber)
                {
                    //配列の数を最小値にする
                    minnumber = array[i];
                }
            }

            return minnumber;
        }

        private static int GetArrayMaxNumber(int[] array)
        {
            //最小値
            int maxnumber = array[0];

            //配列の最後に到達するまで繰り返す、また１から始まるのは０番目の配列が標準値となっているため
            for (int i = 1; i <= array.Length -1; i++)
            {
                //もし最小値が配列の数よりも大きいのなら
                if (array[i] > maxnumber)
                {
                    //配列の数を最小値にする
                    maxnumber = array[i];
                }
            }

            return maxnumber;
        }

        //private static int[] GetEvenNumberList(int[] array)
       // {
            //int arrayLength = 1;

            //int[] answerArray = new int[] {};

            //for (int i = 0; i <= array.Length - 1; i++)
            //{
                //if(array[i] % 2 == 0)
                //{
                    //return array[i];
;                //}
            //}
        }
    }

    //
}
