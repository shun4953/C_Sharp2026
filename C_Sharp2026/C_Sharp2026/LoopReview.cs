using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    //
    internal class LoopReview
    {
        private static void Main(string[] args)
        {
            /*
            
            //問題１
            Console.WriteLine("問題１");
            
            //合計数
            int sum = 0;

            //iが２０に到達するまで繰り返す、iは足す数としても扱われる
            for(int i = 1; i <= 20; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("１から２０までを足した合計数は{0}です", sum);

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            //合計数のリセット
            sum = 0;

            //countを追加した上で２１にする
            int count = 21;

            //countが４０に到達するまで繰り返す、countは足す数として扱われる
            while (count <= 40)
            {
                sum = sum + count;

                //countを１ずつ足す
                count++;
            }
            Console.WriteLine("２１から４０までを足した合計数は{0}です", sum);

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題３");

            Console.WriteLine("数に何倍掛けますか？");

            //掛ける倍数
            int multeple = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //1,2,3,4,5,6,7の入った配列
            int[] array = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            //数列分繰り返す
            foreach (int i in array)
            {
                //掛けた数値を表示する
                Console.WriteLine(i * multeple);
            }

            Console.WriteLine();

            //

            //問題４
            Console.WriteLine("問題４");

            //8,2,3,4,5,6,7,1の入った配列
            int[] array = new int[8] { 8, 2, 3, 4, 5, 6, 7, 1 };

            Console.WriteLine("数値に何倍掛けますか？");

            //掛ける倍数
            int multeple = int.Parse(Console.ReadLine());

            //１０００以上？
            bool thousandovre = false;

            Console.WriteLine();

            //iが配列の最後に到達するまで繰り返す
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i] * multeple);

                //もし倍にした数値が１０００を超えたのなら
                if (array[i] * multeple >= 1000)
                {
                    //thousandovreをtrueにする
                    thousandovre = true;
                }

            }

            //もしthousandoverが１以上あったのなら表示する
            if (thousandovre == true)
            {
                Console.WriteLine("この配列には１０００以上の数が入っています");
            }

            Console.WriteLine();

            //問題５
            Console.WriteLine("問題５");

            Console.WriteLine("自然数を入力してください");

            //入力した自然数
            int naturalnumber = int.Parse(Console.ReadLine());

            //繰り返した回数
            int count = 0;

            //無限に繰り返す
            while(true)
            {
                //もし自然数が偶数なら
                if (naturalnumber % 2 == 0)
                {
                    //自然数を２で割る
                    naturalnumber = naturalnumber / 2;
                }
                //自然数が偶数ではなく奇数なら
                else
                {
                    //自然数を３倍掛けた上に、１を足す
                    naturalnumber = naturalnumber * 3 + 1;
                }

                Console.WriteLine(naturalnumber);

                //countに１を足す
                count++;

                //もし自然数が１なら
                if (naturalnumber == 1)
                {
                    //ループを止める
                    break;
                }
            }

            Console.WriteLine("{0}回の計算で１にたどり着きました", count);

            Console.WriteLine();

            */

            //問題６
            Console.WriteLine("問題６");

            //2,4,6,8,10の入った配列
            int[] array = new int[5] { 2, 4, 6, 8, 10 };


            //iが配列の最後に到達するまで繰り返す
            for (int i = 0; i <= array.Length - 1; i++)
            {

                //計算した時の合計数
                int sum = 1;

                //j(倍数)が配列に入っている数値に到達するまで繰り返す、１は１倍である
                for (int j = 2; j <= array[i]; j++)
                {
                    sum = sum * j;
                }

                Console.WriteLine(sum);
            }
        }
    }
    //
}
