using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    //
    internal class MethodReviewPlus
    {
        private static void Main(string[] args)
        {
            /*

            //問題１
            Console.WriteLine("問題１");

            CollShimuraTeacher();

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            //入力値
            int number = GetInputNumber();

            Console.WriteLine(number);

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題３");

            //入力値
            int numberB = int.Parse(Console.ReadLine());

            CheckPrimitiveNumber(numberB);

            Console.WriteLine();

            */

            //問題４
            Console.WriteLine("問題４");

            //一つ目の入力値
            int num1 = int.Parse(Console.ReadLine());

            //二つ目の入力値
            int num2 = int.Parse(Console.ReadLine());

            Calcation(num1, num2, out int add, out int sub);

            Console.WriteLine("足し算の結果は{0}", add);

            Console.WriteLine("引き算の結果は{0}", sub);

            Console.WriteLine();

            //問題５
            Console.WriteLine("問題５");

            //ブレイクされるまで繰り返す
            for(; ; )
            {
                //もし会話ループを止める指示が出たのなら
                if(!CheckInput())
                {
                    //ループを止める
                    break;
                }
            }
        }

        /// <summary>
        /// 志村先生を表示するメソッド
        /// </summary>
        private static void CollShimuraTeacher()
        {
            //「志村先生」と返す
            Console.WriteLine("志村先生");
        }

        /// <summary>
        /// ０より小さいなら０にし、１００より大きいなら１００にする入力値を出すメソッド
        /// </summary>
        /// <returns>補正の入った入力値</returns>
        private static int GetInputNumber()
        {
            //入力値
            int inputNumber = int.Parse(Console.ReadLine());

            //もし入力された数が０より小さいのなら
            if (inputNumber < 0)
            {
                //０にする
                inputNumber = 0;

                //「０より小さかったため直しました」と返す
                Console.WriteLine("０より小さいため補正します");
            }
            //もし入力された数が１００より大きいのなら
            else if (inputNumber > 100)
            {
                //１００にする
                inputNumber = 100;

                //「１００より大きかったため直しました」と返す
                Console.WriteLine("１００より大きいため補正します");
            }

            //補正された入力値を返す
            return inputNumber;
        }

        /// <summary>
        /// 素数かどうか判定するメソッド
        /// </summary>
        /// <param name="numberB">入力された数</param>
        private static void CheckPrimitiveNumber(int numberB)
        {
            //素数を計算するための数
            int copyNumberB = numberB;

            //iの数を２で割ったもの、更に小数点は切り捨てとなる
            float half = 0.0f;

            //その数は素数か？
            bool primeNumber = true;

            //iを２で割って、第一小数点を切り捨てる
            half = MathF.Floor(copyNumberB / 2);

            //素数かどうかを特定するためのループ、2は最初に2で割ることを表している
            for (int j = 2; j <= half; j++)
            {
                //もし余りが０なら
                if (copyNumberB % j == 0)
                {
                    //素数ではないので、primenumberをfalseにする
                    primeNumber = false;

                    //ループを止める
                    break;
                }
            }

            //もし素数だったのなら
            if (primeNumber == true)
            {
                //「その数は素数でした」と返す
                Console.WriteLine("{0}は素数です", numberB);
            }
            //素数ではなかったのなら
            else
            {
                //「その数は素数ではありませんでした」と返す
                Console.WriteLine("{0}は素数ではありません", numberB);
            }
        }

        /// <summary>
        /// 足し算と引き算のメソッド
        /// </summary>
        /// <param name="num1">一番目の入力値</param>
        /// <param name="num2">二番目の入力値</param>
        /// <param name="add">足された数</param>
        /// <param name="sub">引かれた数</param>
        private static void Calcation(int num1,int num2 ,out int add,out int sub)
        {
            //足し算
            add = num1 + num2;

            //もし一番目の数が大きいのなら
            if(num1 >= num2)
            {
                //一番目の数を引く引き算
                sub = num1 - num2;
            }
            //もし二番目の数が大きいのなら
            else
            {
                //二番目の数を引く引き算
                sub = num2 - num1;
            }
        }

        /// <summary>
        /// 会話のメソッド
        /// </summary>
        /// <returns>ループを止めるかを決める</returns>
        private static bool CheckInput()
        {
            //入力された言葉
            string inputText = Console.ReadLine();

            //もし「こんにちは」と言われたのなら
            if (inputText == "こんにちは")
            {
                //「こんにちは！」と返す
                Console.WriteLine("こんにちは！");
            }
            //もし「調子は？」と言われたのなら
            else if (inputText == "調子は？" || inputText == "調子は?")
            {
                //「元気です！あなたは？」と返す
                Console.WriteLine("元気です！あなたは？");
            }
            //もし「さようなら」と言われたのなら
            else if (inputText == "さようなら")
            {
                //「またね！ばいばい！」と返す
                Console.WriteLine("またね！ばいばい！");
            }
            //もし「exit」と言われたのなら
            else if (inputText == "exit")
            {
                //会話のループを止める
                return false;
            }
            //もしそれ以外の言葉を言われたのなら
            else
            {
                //機械的な「理解できなかったです」を返す
                Console.WriteLine("スイマセン ヨクワカリマセン");
            }

            //会話のループを続ける
            return true;
        }
    }
    //
}
