using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 夏休みの課題
{
    /*
    internal class ForAndIfReview
    {
        private static void Main(string[] args)
        {
            //

            //問題１
            Console.WriteLine("問題１");

            //数値が１００になるまで繰り返す、１から数え始めるためiは１から始まる
            for(int i = 1; i <= 100; i++)
            {
                //もし数値が偶数なら
                if (i % 2 == 0)
                {
                    //その数値を表示する
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            //数値が１００になるまで繰り返す、１から数え始めるためiは１から始まる
            for (int i = 1; i <= 100; i++)
            {
                //もし数値が３の倍数かつ５の倍数なら
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //FizzBizzと表示する
                    Console.WriteLine("FizzBuzz");
                }
                //もし数値が３の倍数なら
                else if (i % 3 == 0)
                {
                    //fizzと表示する
                    Console.WriteLine("Fizz");
                }
                //もし数値が５の倍数なら
                else if (i % 5 == 0)
                {
                    //Buzzと表示する
                    Console.WriteLine("Bizz");
                }
                //もしすべての条件に当てはまらないのなら
                else
                {
                    //数値を表示する
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題3");

            bool truemultiplication = false;

            Console.WriteLine("数を入力してください");

            int inputnumber = int.Parse(Console.ReadLine());

            //もし入力した数値が九九では絶対に出てこない数になっているのなら
            if (inputnumber > 81 || inputnumber < 1)
            {
                Console.WriteLine("九九の答えにありません");
            }
            else
            {
                //九九の段の部分
                for (int i = 1; i <= 9; i++)
                {
                    //九九の行列の部分
                    for (int j = 1; j <= 9; j++)
                    {
                        //もし九九の答えが入力した数値と一致したのなら
                        if (i * j == inputnumber)
                        {
                            //i*jを表示する
                            Console.WriteLine("{0} × {1}",i,j);

                            //掛け算の証明をtrueにする
                            truemultiplication = true;
                        }
                        //もし九九の答えが入力した数より大きいまたは９倍しても数値に到達しないのなら
                        else if(i * j > inputnumber || i * 9 < inputnumber)
                        {
                            //次の段へ進む
                            break;
                        }
                    }
                }

                //もし九九に数値の答えがないのなら
                if(truemultiplication == false)
                {
                    Console.WriteLine("九九の答えにありません");
                }
            }

            Console.WriteLine();

            //

            //問題４
            Console.WriteLine("問題４");

            Console.WriteLine("２以上の数を入力してください");

            int inputnumber = int.Parse(Console.ReadLine());

            while(true)
            {
                if (inputnumber == 2 || inputnumber == 3 || inputnumber == 5 || inputnumber == 7)
                {
                    Console.WriteLine(inputnumber);

                    break;
                }

                if (inputnumber % 2 == 0)
                {
                    Console.WriteLine("2");

                    inputnumber = inputnumber / 2;
                }
                else if (inputnumber % 3 == 0)
                {
                    Console.WriteLine("3");

                    inputnumber = inputnumber / 3;
                }
                else if (inputnumber % 5 == 0)
                {
                    Console.WriteLine("5");

                    inputnumber = inputnumber / 5;
                }
                else if (inputnumber % 7 == 0)
                {
                    Console.WriteLine("7");

                    inputnumber = inputnumber / 7;
                }
                else
                {
                    Console.WriteLine(inputnumber);

                    break;
                }
            }

            Console.WriteLine();

            //

            //問題５
            Console.WriteLine("問題５");

        }
    }

    */
}
