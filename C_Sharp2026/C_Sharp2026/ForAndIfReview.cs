using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    /*
    internal class ForAndIfReview
    {
        private static void Main(string[] args)
        {
            //

            //問題１
            Console.WriteLine("問題１");

            //iが１００に到達するまで繰り返す
            for (int i = 1; i <= 100; i++)
            {
                //もし２で割った数に余りがなかったなら
                if (i % 2 == 0)
                {
                    //iを表示する
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            //その数は３倍か？
            bool fizz = false;

            //その数は５倍か？
            bool buzz = false;

            //iが１００に到達するまで繰り返す
            for (int i = 1; i <= 100; i++)
            {
                //fizzのスイッチをfalseに戻す
                fizz = false;

                //buzzのスイッチをfalseに戻す
                buzz = false;

                //もし３割った数に余りがなかったなら
                if (i % 3 == 0)
                {
                    //fizzのスイッチをtrueにする
                    fizz = true;
                }
                
                //もし５で割った数に余りがなかったなら
                if (i % 5 == 0)
                {
                    //buzzのスイッチをtrueにする
                    buzz = true;
                }

                //もしfizzとbuzzがtrueなら
                if (fizz == true && buzz == true)
                {
                    //FissBuzzと表示する
                    Console.WriteLine("FizzBuzz");
                }
                //もしfizzのみがtrueなら
                else if (fizz == true)
                {
                    //Fizzと表示する
                    Console.WriteLine("Fizz");
                }
                //もしbuzzのみがtrueなら
                else if (buzz == true)
                {
                    //Buzzと表示する
                    Console.WriteLine("Buzz");
                }
                //もし今までの条件に当てはまらなかったのなら
                else
                {
                    //iを表示する
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題３");

            Console.WriteLine("数を入力してください");

            int inputnumber = int.Parse(Console.ReadLine());

            //その入力された数は九九で答えられる数か？
            bool kuku = false;

            //掛けられる数、９の位まで繰り返す
            for (int i = 1; i <= 9; i++)
            {
                //もしもiで割った数が０かつi*９よりも小さいのなら九九の表示を始める
                if (inputnumber % i == 0 && inputnumber <= i * 9)
                {
                    //九九である事が証明されたためkukuをtrueにする
                    kuku = true;

                    //掛ける数、９倍になるまで繰り返す
                    for (int j = 1; j <= 9; j++)
                    {
                        //もし入力された数値とiとｊが掛けられた数と一致した場合
                        if (inputnumber == i * j)
                        {
                            //i*jを表示する
                            Console.WriteLine("{0} × {1}", i, j);

                            break;
                        }
                    }
                }
            }
            //もし九九で求められない数なら
            if(kuku == false)
            {
                //「九九の答えにありません」と表示する
                Console.WriteLine("九九の答えにはありません");
            }
        }
    }
    */
}
