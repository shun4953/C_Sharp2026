using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    //
    internal class LoopReview2
    {
        private static void Main(string[] args)
        {
            /*

            //問題7
            Console.WriteLine("問題７");

            Console.WriteLine("数を入力してください");

            int inputnumber = int.Parse(Console.ReadLine());

            //階乗の時に使われる合計値
            long Factorialsum = 1;

            //普通の合計値
            int sum = 0;

            //もし入力された数が０以下なら
            if (inputnumber <= 0)
            {
                //なにも起こさない
            }
            //もし１つ目の条件を満たさなかった上で入力された数が１５以下なら
            else if (inputnumber <= 15)
            {
                //入力された数分階乗をする
                Console.WriteLine();

                //i(倍数)が入力された数に到達するまで繰り返す、２は２倍である
                for (int i = 2; i <= inputnumber; i++)
                {
                    Factorialsum = Factorialsum * i;

                    Console.WriteLine(Factorialsum);
                }
            }
            //もし２つ目の条件が満たなかった上で入力された数が１００００以下なら
            else if (inputnumber <= 10000)
            {
                //足した数値が入力された数と同じになるまで続ける
                Console.WriteLine();
                
                //i(足される数値)が入力された数に到達するまで繰り返す
                for (int i = 1; i <= inputnumber; i++)
                {
                    sum = sum + i;
                }

                Console.WriteLine(sum);
            }
            //もしすべての前提条件を満たさないのなら
            else
            {
                //「数が大きいので計算ができません」と表示する
                Console.WriteLine("数が大きいので計算ができません");
            }

            Console.WriteLine();

            */

            //問題８
            Console.WriteLine("問題８");

            //掛けられる数、９の位まで繰り返す
            for (int i = 1; i <= 9; i++)
            {
                //掛ける数、９倍になるまで繰り返す
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} × {1} = {2}",i ,j ,i * j);
                }
            }

            Console.WriteLine();

            //問題９
            Console.WriteLine("問題９");

            Console.WriteLine("数を入力してください");

            int inputnumber = int.Parse(Console.ReadLine());

            //iの数を２で割ったもの、更に小数点は切り捨てとなる
            float half = 0.0f;

            //その数は素数か？
            bool primenumber = false;

            //二回目のループを始めたか？
            bool loop = false;

            Console.WriteLine();

            for (int i = 1; i <= inputnumber; i++)
            {
                //iを２で割って、第一小数点を切り捨てる
                half = MathF.Floor(i / 2);

                //初回ループに戻す
                loop = false;

                //素数かどうかを特定するためのループ、１は最初に１で割ることを表している
                for (int j = 1; j <= i; j++)
                {
                    //もし初回ループ以外で余りが０なら
                    if (i % j == 0　&& loop == true)
                    {
                        //素数ではないので、primenumberをfalseにする
                        primenumber = false;

                        //ループを止める
                        break;
                    }
                    //もしjがhalfと同じ数になったのなら
                    if (half == j)
                    {
                        //素数を表示する
                        Console.WriteLine(i);

                        //素数なのでprimenumberをtrueにする
                        primenumber = true;

                        //ループを止める
                        break;
                    }
                    loop = true;
                }
            }
            //もし入力された数が素数なら
            if(primenumber == true)
            {
                Console.WriteLine("入力された数も素数です");
            }
        }
    }
    //
}
