using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    //
    internal class RandomClass
    {
        private static void Main(string[] args)
        {
            Random rand = new Random();

            /*

            for (int i = 0; i < 5; i++)
            {
                //変数Aにランダム変数の０～１０未満までの数を当てはめる？
                int a = rand.Next(0, 10);

                Console.WriteLine("ランダムな数字は「{0}」", a);
            }

            //

            //問題１
            Console.WriteLine("問題１");

            Console.WriteLine("予想した数を入力してください");

            Console.WriteLine("入力する数は１～１０の範囲でお願いします");

            //予想した数
            int prediction = int.Parse(Console.ReadLine());

            //もし数が１０を超えたのなら
            if (prediction > 10)
            {
                Console.WriteLine("入力された数が１０よりオーバーしました");

                Console.WriteLine("やり直してください");
            }
            
            //そうでなければ
            else
            {
                //ランダムに生成される予測の答え
                int answer = rand.Next(1, 11);

                //もし予測した数がランダムで生成された答えと一致したなら
                if (prediction == answer)
                {
                    Console.WriteLine("あなたの予測は当たりました！");
                }
                //一致していなかったら
                else
                {
                    Console.WriteLine("あなたの予測は外れました...");
                }

                Console.WriteLine("正解は{0}でした", answer);
            }
            Console.WriteLine();

            */

            //問題２
            Console.WriteLine("問題２");

            //ランダムに生成される予測の答え
            int answer = rand.Next(50, 101);

            //デバッグ用answerの表示
            Console.WriteLine("{0}", answer);

            //予測が当たるまで繰り返す
            while (true)
            {
                Console.WriteLine("予想した数を入力してください");

                Console.WriteLine("入力する数は５０～１００の範囲でお願いします");

                //予想した数
                int prediction = int.Parse(Console.ReadLine());
                
                //もし予測した数が５０より小さいまたは１００より大きいのなら
                if (prediction < 50 || prediction > 100)
                {
                    Console.WriteLine("入力された数が５０より小さいまたは１００より大きいです");

                    Console.WriteLine("やり直してください");

                    Console.WriteLine();
                }
                //基準を満たしていたのなら
                else
                {
                    //もし予測した数がランダムで生成された答えと一致したなら
                    if (prediction == answer)
                    {
                        Console.WriteLine("あなたの予測は当たりました！");

                        break;
                    }
                    //一致していなかったら
                    else
                    {
                        Console.WriteLine("あなたの予測は外れました...");

                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("正解は{0}でした", answer);
        }
    }
}
