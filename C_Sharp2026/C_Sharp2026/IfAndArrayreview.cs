using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class IfAndArrayreview
    {
        //
        private static void Main(string[] args)
        {
            //問題１
            /*
            Console.WriteLine("数を入力してください");

            int input = int.Parse(Console.ReadLine());

            if (input > 100)
            {
                Console.WriteLine("この数は１００より大きいです");
            }
            else if (input < 100)
            {
                Console.WriteLine("この数は１００より小さいです");
            }
            else
            {
                Console.WriteLine("この数は１００です");
            }

            Console.WriteLine();
            //
            //問題２

            Console.WriteLine("交換前の配列");

            float[] array = new float[7] { 1.0f, 5.0f, 99.0f, 12.5f, 3.0f, 22.22f, 1024.0f };

            Console.WriteLine("{0}、{1}、{2}、{3}、{4}、{5}、{6}", array[0], array[1], array[2], array[3], array[4], array[5], array[6]);

            Console.WriteLine();

            //問題３

            Console.WriteLine("交換後の配列");

            float shelter = array[0];

            array[0] = array[6];

            array[6] = shelter;

            Console.WriteLine("{0}、{1}、{2}、{3}、{4}、{5}、{6}", array[0], array[1], array[2], array[3], array[4], array[5], array[6]);

            Console.WriteLine();

            //問題４

            Console.WriteLine("配列一覧");

            int number = 0;

            for (int numberlist = 1; numberlist <= 7; numberlist++)
            {
                Console.WriteLine("{0}番　{1}", number, array[number]);
                number++;
            }

            Console.WriteLine("どの番号を倍増させたいですか？");

            int replacement = int.Parse(Console.ReadLine());

            if (replacement < 0 || replacement >= 7)
            {
                Console.WriteLine("これは不正な配列番号です");

                Console.WriteLine("やりなおしてください");
            }
            else
            {
                Console.WriteLine("その数字に何倍掛けますか？");

                float answer = array[replacement] * float.Parse(Console.ReadLine());

                if (answer >= 10000)
                {
                    Console.WriteLine("これは１００００以上の大きな数字です");
                }
                else
                {
                    Console.WriteLine("{0}", answer);
                }
            }

            Console.WriteLine();

            //問題５

            Console.WriteLine("配列Bの入力値は？");

            int[] araayA = new int[4] { 1, 9, 2, 8 };

            int[] arrayB = new int[4] { 3, 7, 4, int.Parse(Console.ReadLine())};

            int sumA = araayA[0] + araayA[1] + araayA[2] + araayA[3];

            int sumB = arrayB[0] + arrayB[1] + arrayB[2] + arrayB[3];

            if (sumA > sumB)
            {   
                Console.WriteLine("配列Aの合計値は配列Bの合計値より{0}大きい", sumA - sumB);
            }
            else if (sumA < sumB)
            {
                Console.WriteLine("配列Bの合計値は配列Aの合計値より{0}大きい", sumB - sumA);
            }
            else
            {
                Console.WriteLine("配列Aと配列Bの合計値は同じ");
            }

            Console.WriteLine();
            */
            //問題６

            int[] arrayC = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("一つだけ数字を入力してください");

            arrayC = new int[8] { 1, 2, int.Parse(Console.ReadLine()), 3, 4, 5, 6, 7 };

            Console.WriteLine("{0}、{1}、{2}、{3}、{4}、{5}、{6}、{7}", arrayC[0], arrayC[1], arrayC[2], arrayC[3], arrayC[4], arrayC[5], arrayC[6], arrayC[7]);

        }
        
    }
}
