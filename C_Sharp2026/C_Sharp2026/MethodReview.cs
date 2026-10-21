using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    /*
    internal class MethodReview
    {
        private static void Main(string[] args)
        {
            /*

            //問題１
            Console.WriteLine("問題１");

            //関先生を呼ぶメソッドに移動する
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

            //

            //問題４
            Console.WriteLine("問題４");

            int[] array = new int[] { 5, 7, 12, 9, 15, 8, 23, 4, 10 };

            int[] evenArray = GetEvenNumberList(array);

            Console.WriteLine(evenArray.Length);

            foreach (int i in evenArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        private static void CallSekiTeacher()
        {
            Console.WriteLine("関先生！");
        }

        private static int Addition(int num1, int num2)
        {
            //二つの数値の合計
            int sum = num1 + num2;

            return sum;
        }

        private static int GetArrayMinNumber(int[] array)
        {
            //配列の中で最も小さい値
            int min = array[0];

            //配列の最後に到達するまで繰り返す　iが１なのはminの参照値が０番目の数値であるため
            for (int i = 1; i < array.Length; i++)
            {
                //もし配列の数値がminより小さかったなら
                if (min > array[i])
                {
                    //minを配列の数値に更新する
                    min = array[i];
                }
            }

            return min;
        }

        private static int GetArrayMaxNumber(int[] array)
        {
            //配列の中で最も大きい値
            int max = array[0];

            //配列の最後に到達するまで繰り返す　iが１なのはmaxの参照値が０番目の数値であるため
            for (int i = 1; i < array.Length; i++)
            {
                //もし配列の数値がmaxより大きかったのなら
                if (max < array[i])
                {
                    //maxを配列の数値に更新する
                    max = array[i];
                }
            }

            return max;
        }

        private static int[] GetEvenNumberList(int[] array)
        {
            int arrayLength = 0;

            int[] answerArray = new int[arrayLength];

            Console.WriteLine(answerArray.Length);

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    //answerArray[i] = array[i];

                    arrayLength++;
                }
            }

            Console.WriteLine(arrayLength);

            Console.WriteLine(answerArray.Length);

            return answerArray;
        }

    }

    */
}
