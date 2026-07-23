using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    /*
    internal class AllReview
    {
        private static void Main(string[] args)
        {
            //

            //問題１
            Console.WriteLine("問題１");

            //入力された数を保存するための関数
            int[] arrayA = new int[10] ;

            //関数の配列分まで繰り返す
            for(int i = 0; i < arrayA.Length; i++)
            {
                //関数に入力した数の２倍を与える
                arrayA[i] = int.Parse(Console.ReadLine()) * 2;
            }

            Console.WriteLine();

            //関数の配列をすべて表示する
            for(int i = 0; i < arrayA.Length; i++)
            {
                Console.WriteLine(arrayA[i]);
            }

            Console.WriteLine();

            //

            //問題２
            Console.WriteLine("問題２");

            //入力された数を保存するための関数
            int[] arrayB = new int[10];

            //偶数と奇数を切り替えるスイッチ
            bool odd = false;

            //関数の配列分まで繰り返す
            for (int i = 0; i < arrayB.Length; i++)
            {
                //関数に入力した数を与える
                arrayB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("偶数：");

            //すべての並列の数を調べるまで繰り返す
            for (int i = 0; i < arrayB.Length; i++)
            {
                //もしその数が偶数なら
                if (arrayB[i] % 2 == 0)
                {
                    //偶数だった数を表示する
                    Console.Write(arrayB[i] + " ");
                }
            }

            Console.WriteLine();

            Console.Write("奇数：");

            //もう一度すべての並列の数を調べるまで繰り返す
            for (int i = 0; i < arrayB.Length; i++)
            {
                //もしその数が奇数なら
                if (arrayB[i] % 2 == 1)
                {
                    //奇数だった数を表示する
                    Console.Write(arrayB[i] + " ");
                }
            }

            Console.WriteLine();

            //

            //問題３
            Console.WriteLine("問題３");

            //入力した数
            int number = int.Parse(Console.ReadLine());

            //累乗する数＆平方数のかけている数
            int save = 1;

            //その数は平方数か？
            bool square = false;

            //無限ループ
            while (true)
            {
                //もし累乗した数と入力した数が一致したなら
                if (number == save * save)
                {
                    //平方数であると伝える
                    square = true;

                    //ループを止める
                    break;
                }
                //もし累乗した数が入力した数よりも超えてしまったのなら
                else if(number < save)
                {
                    //ループを止める
                    break;
                }
                save++;
            }

            //もしその入力された数が平方数なら
            if (square == true)
            {
                Console.WriteLine("この数は{0} * {0}の平方数です",save);
            }
            //もし入力された数が平方数ではなかったのなら
            else
            {
                Console.WriteLine("この数は平方数ではありません");
            }

            //

            //メモ
            //変数は入力できるやつ
            //大きい順と小さい順は出てきた数と比べる　数更新式

            //問題４
            Console.WriteLine("問題４");

            Console.WriteLine("配列の大きさを入力してください");

            //並列の長さを決める
            int array_length = int.Parse(Console.ReadLine());

            Console.WriteLine("配列の大きさ分数値を入力してください");

            int[] array = new int[array_length];

            //配列分の数を入力しきるまで繰り返す
            for(int i = 0; i < array_length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //数の最大数、仮の最大数を配列の１番目にする
            int big_number = array[0];

            //数の最小数、仮の最小数を配列の１番目にする
            int small_number = array[0];

            //すべての配列の数を検証するまで繰り返す、１番目の配列は基準値として使われているため、２番目の配列から始まっている
            for (int i = 1; i < array.Length; i++)
            {
                //もし現在の配列の数が最大数よりも大きかったのなら
                if(big_number < array[i])
                {
                    //最大数を更新する
                    big_number = array[i];
                }
                //もし現在の配列の数が最小数よりも小さかったのなら
                if (small_number > array[i])
                {
                    //最小数を更新する
                    small_number = array[i];
                }
            }

            Console.WriteLine("一番大きい数：{0}　一番小さい数：{1}", big_number, small_number);

            //

            //メモ２
            //数の範囲は０を含めた２０１種類だと思われる
            //最頻値はおそらく多く出てきた数だと思われる(多分)
            //配列はランダム数[１０００]と数の合計値[２０１]が必要になると思われる
            //最も多かった数の総数とまだ出ていない数の総数を比べ、多数のほうが大きかった場合止めてもよい
            //最頻値を合計配列の順番から引き出す際は-１０１をする　そうしないとランダムに出した数ではない

            //問題５
            Console.WriteLine("問題５");

            int[] array_random = new int[1000];

            int rest_number = 1000;

            Random rand = new Random();

            for (int i = 0; i < array_random.Length; i++)
            {
                array_random[i] = rand.Next(-100, 101);
            }

            int target = -100;

            int maximum = 0;

            int[] array_mode = new int[201];

            for (int i = 0; i < array_random.Length; i++)
            {
                for (int j = 0; j < array_mode.Length; j++)
                {
                    if(j - 100 == array_random[i])
                    {

                    }
                }
            }
        }
    }
    */
}
