using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class Loop
    {
        //
        private static void Main(string[] arts)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("iを出力：{0}", i);
            }
            //
            int[] array = new int[5] { 7, 2, 5, 4, 5 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            //
            int a = 0;
            while(a < 10)
            {
                Console.WriteLine("aの中身を出力：{0}", a);
                a++;
            }
            //
            int a = 0;
            for(; ; )
            {
                a++;
                Console.WriteLine("{0}回目のループ中", a + 1);

                if (a >= 5)
                {
                    break;
                }
            }
            int b = 0;

            while(true)
            {
                b++;
                Console.WriteLine("{0}回目のループ中", b);

                if (b >= 5)
                {
                    break;
                }
            }
            //
            //問題１
            Console.WriteLine("問題１");

            int answer = 2;

            for (int i = 0; i < 7; i++)
            {
                answer = answer * 2;
            }

            Console.WriteLine(answer);

            //問題２
            Console.WriteLine("問題２");

            int[] arrey = new int[10] { 152, 954, 856, 742, 851, 148, 365, 333, 214, 422 };
            
            int sum = 0;

            foreach(int i in arrey)
            {
                sum = sum + i;

                Console.WriteLine(sum);
            }
            
            //問題３
            Console.WriteLine("問題３");
            Console.WriteLine("乗算したい値を入力してください");

            int x = int.Parse(Console.ReadLine());

            int multiple = x;

            Console.WriteLine("何乗しますか？");

            int y = int.Parse(Console.ReadLine());
            //一回目という意味(多分)
            for (int i = 1; i < y; i++)
            {
                x = x * multiple;
            }

            Console.WriteLine(x);
            //
            //問題４
            Console.WriteLine("問題４");
            Console.WriteLine("このプログラムは入力した数字を足し続けることができます");
            Console.WriteLine("もし終了したい場合は「0」と入力してください");

            //文字通りの合計数
            int sum = 0;
            
            //何回数値が足されたか
            int times = 0;
            
            //無限ループ用のループ
            while (true)
            {
                Console.WriteLine("現在足された回数は{0}回です", times);

                Console.WriteLine("足したい数字を入力してください");
                
                //足そうとしている数値
                int plus = int.Parse(Console.ReadLine());

                //もしplusに入力された数値が０なら
                if (plus == 0)
                {
                    //ループを止める
                    break;
                }
                else
                {
                    //今までの合計数に入力した数値を足す
                    sum = sum + plus;

                    Console.WriteLine("現在の合計数は{0}です", sum);

                    //やった回数に１を足す
                    times++;

                    Console.WriteLine();
                }
               
            }
            Console.WriteLine();

            Console.WriteLine("最終的な合計数は{0}でした", sum);

            Console.WriteLine();
            //
            //問題５
            Console.WriteLine("問題５");
            
            //合計数が見れないのを対策するため
            Console.WriteLine("膨大な数字が出てくるため一時的に機能を止めています");

            Console.WriteLine("再開しますか？(数字を打てば再開します)");
            
            //マジで何も影響がない数値(？)
            int nope = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            //１から１０００までの数値
            for (int number = 1; number < 1000; number++)
            {
                //numberを３で割るって余りを出す
                //もしremainderの余りが０なら、
                if(number % 3 == 0)
                {
                    //numberの数値を表示する
                    Console.WriteLine("{0}", number);

                    //Console.WriteLine();
                }
            */

            //問題６
            Console.WriteLine("問題６");
            //素数の総数(デバッグ)
            int testcount = 0;
            //割り切れた回数
            int count = 0;
            //１から１０００までの数値
            for (int number = 1; number < 1000; number++)
            {
                //数値が１なら除外
                if (number == 1)
                {

                }
                else
                {
                    for (int loop = 2; loop <= number; loop++)
                    {
                        //一回目のループなら
                        if (loop == 2)
                        {
                            //割り切れた回数をリセット
                            count = 0;
                        }
                        //もし割った数値に余りがなかったら
                        if (number % loop == 0)
                        {
                            //割り切れた回数に１を足す
                            count++;
                        }
                    }
                    //割り切れた数が１回だけなら表示
                if (count == 1)
                {
                     Console.WriteLine(number);

                     testcount++;
                }

                }
            }
        Console.WriteLine("素数の総数は{0}です",testcount);
        }
    }
}
