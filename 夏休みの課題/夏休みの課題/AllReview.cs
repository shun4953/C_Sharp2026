using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 夏休みの課題
{
    /*
    internal class AllReview
    {
        private static void Main(string[] args)
        {
            //

            //問題１
            Console.WriteLine("問題１");

            //配列
            int[] arrayA = new int[10];

            Console.WriteLine("数を{0}個入力してください",arrayA.Length);

            //すべての配列が埋まるまで繰り返す
            for (int i = 0; i <= arrayA.Length -1; i++)
            {
                arrayA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            //すべての配列が２倍になるまで繰り返す
            for (int i = 0; i <= arrayA.Length -1; i++)
            {
                //数を二倍にしている
                Console.WriteLine(arrayA[i] * 2);
            }

            Console.WriteLine();

            //

            //問題２
            Console.WriteLine("問題２");

            //配列
            int[] arrayB = new int[10];

            Console.WriteLine("数を{0}個入力してください",arrayB.Length);

            //すべての配列が埋まるまで繰り返す
            for (int i = 0; i <= arrayB.Length - 1; i++)
            {
                arrayB[i] = int.Parse(Console.ReadLine());
            }

            //改行
            Console.WriteLine();

            Console.Write("偶数：");

            //最後の数に到達するまで繰り返す
            for (int i = 0; i <= arrayB.Length - 1; i++)
            {
                //もし配列の数値が偶数なら
                if(arrayB[i] % 2 ==0)
                {
                    //その数値を表示する
                    Console.Write(arrayB[i] + " ");
                }
            }

            //改行
            Console.WriteLine();

            Console.Write("奇数：");

            //最後の数に到達するまで繰り返す
            for (int i = 0; i <= arrayB.Length - 1; i++)
            {
                //もし配列の数値が奇数なら
                if (arrayB[i] % 2 == 1)
                {
                    //その数値を表示する
                    Console.Write(arrayB[i] + " ");
                }
            }

            Console.WriteLine();

            //

            //問題３
            Console.WriteLine("問題３");

            int inputnumber = int.Parse(Console.ReadLine());

            //平方数の倍数
            int Squarenumber = 0;

            //平方数かどうかがわかるまで繰り返す
            while (true)
            {
            　　//平方数の倍数を増やす
                Squarenumber++;

            　　//もし平方数と入力した数値が一致したのなら
                if (inputnumber == Squarenumber * Squarenumber)
                {
                    Console.WriteLine("この数は{0} × {0}の平方数です",Squarenumber);

                    break;
                }
            　　//もし平方数が入力した数値を超えてしまったのなら
                else if(inputnumber <= Squarenumber * Squarenumber)
                {
                    Console.WriteLine("この数は平方数ではありません");

                    break;
                }
            }

            //

            //問題４
            Console.WriteLine(Console.ReadLine());

            Console.WriteLine("配列の大きさを入力してください");

            int arraylength = int.Parse(Console.ReadLine());

            Console.WriteLine("配列の大きさ分数値を入力してください");

            int[] array = new int[arraylength];

    　　　　//配列の数値が埋まるまで繰り返す
            for(int i = 0; i <= arraylength - 1; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
       
            //最大値
            int maxnumber = array[0];

            //最小値
            int minnumber = array[0];
            
            //配列の最後まで繰り返す、また１から始まるのは０番目の配列が標準値となっているため
            for (int i = 1; i <= arraylength - 1; i++)
            {
    　　　　　　//もし最大値が配列より小さいのなら
                if (maxnumber <= array[i])
                {
    　　　　　　　　//その配列の数を最大値にする
                    maxnumber = array[i];
                }
    　　　　　　//もし最小値が配列より大きいのなら
                if (minnumber >= array[i])
                {
    　　　　　　　　//その配列の数を最小値にする
                    minnumber = array[i];
                }
            }

            Console.WriteLine("一番大きい数：{0}　一番小さい数：{1}", maxnumber, minnumber);
        }
    }
    */
}
