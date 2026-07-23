using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    //
    internal class Method
    {
        private static void Main(string[] args)
        {
            /*

            Console.WriteLine("体重[kg]を入力してください");
            float weight = GetInputNumber();//floatになっている

            Console.WriteLine("身長[m]を入力してください");
            float height = GetInputNumber();

            float bmi = weight / (height * height);
            Console.WriteLine("あなたのBMIは{0}です", bmi);

            CheckBMILevel(bmi);//voidになっている

            //

            //問題１
            Console.WriteLine("問題１");

            //名前を保存する
            string name = Console.ReadLine();

            Greeting(name);

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            int[] pointArray = new int[12] { 92, 55, 24, 16, 8, 78, 84, 23, 64, 100, 61, 14 };

            //平均点
            float average = GetPointAverage(pointArray);

            Console.WriteLine("このクラスの平均点は{0}です。", average);

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題３");

            int random = GetRandomNum(0, 100);

            //ランダムに出た数を当てられるまで繰り返す
            while (true)
            {
                //入力された数
                int input = int.Parse(Console.ReadLine());

                //もしランダムに出した数と入力した数が一致したのなら
                if(CheckBingoRandomNum(random,input))
                {
                    //このループを止める
                    break;
                }
            }

            */

            //問題４
            Console.WriteLine("問題４");

            CalclatorArea();
        }

        private static void CheckBMILevel(float bmi)
        {
            if (bmi < 18.5f)
            {
                Console.WriteLine("ガリ");
            }
            else if (bmi < 25.0f)
            {
                Console.WriteLine("普通");
            }
            else if (bmi < 30.0f)
            {
                Console.WriteLine("ぽっちゃり");
            }
            else if (bmi < 35.0f)
            {
                Console.WriteLine("ちょいデブ");
            }
            else if (bmi < 40.0f)
            {
                Console.WriteLine("デブ");
            }
            else
            {
                Console.WriteLine("力士");
            }
        }

        //void以外の返り値を設定したときは呼び出すときに=の右側に来る
        private static float GetInputNumber()
        {
            float number = 0;

            if (float.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }

            return 0.0f;
        }

        private static void Greeting(string name)
        {
            Console.WriteLine("{0}さんこんにちは", name);
        }

        private static float GetPointAverage(int[] pointArray)
        {
            //点数の合計値
            float sum = 0;

            //点数の合計値を求めきるまで繰り返す
            for (int i = 0; i < pointArray.Length; i++)
            {
                sum = sum + pointArray[i];
            }

            //平均値の答え
            float answer = sum / pointArray.Length;

            return answer;
        }

        private static int GetRandomNum(int min, int max)
        {
            Random rand= new Random();
            return rand.Next(min, max);
        }

        private static bool CheckBingoRandomNum(int random, int input)
        {
            //絶対値を求める
            int absolute = Math.Abs(random - input);

            //もし絶対値が０と一致したのなら
            if (absolute == 0)
            {
                Console.WriteLine("正解！！");
                return true;
            }
            //もし絶対値が３以下なら
            else if(absolute <= 3)
            {
                Console.WriteLine("おしい！あとちょっと！");
            }
            //もし絶対値が１０以下なら
            else if (absolute <= 10)
            {
                Console.WriteLine("結構近いかも？");
            }
            //もし絶対値が２０以下なら
            else if (absolute <= 20)
            {
                Console.WriteLine("近からず遠からず");
            }
            //もし絶対値が２１以上なら
            else
            {
                Console.WriteLine("全然ダメ");
            }
        
            return false;
        }

        private static void CalclatorArea()
        {
            Console.WriteLine("面積を求めたい図形を選択してください");

            Console.WriteLine("四角形なら[s]、三角形なら[t]、円形なら[c]と入力してください");

            string shapes = Console.ReadLine();

            //もし入力された文字がsなら
            if (shapes == "s")
            {
                //四角形を計算するメソッドへ移動する
                RectangleArea();
            }
            //もし入力された文字がtなら
            else if (shapes == "t")
            {
                //三角形を計算するメソッドへ移動する
                TriangleArea();
            }
            //もし入力された文字がcなら
            else if(shapes == "c")
            {
                //円形を計算するメソッドへ移動する
                CircleArea();
            }
            //もし三つの条件が当てはまらないのなら表示する
            else
            {
                Console.WriteLine("不正な文字列です");

                Console.WriteLine("やり直してください");
            }
        }

        private static float InputNumberArea()
        {
            //入力された数値
            float number = 0;

            if (float.TryParse(Console.ReadLine(), out number))
            {
                //入力された数値を出力する
                return number;
            }

            //何も入力されなかったら数値を０と出力する
            return 0.0f;
        }

        private static void RectangleArea()
        {
            Console.WriteLine("四角形の縦の長さはどのくらいですか");

            //四角形の縦の長さの値
            float vertical = InputNumberArea();

            Console.WriteLine("四角形の横の長さはどのくらいですか？");

            //四角形の横の長さの値
             float width = InputNumberArea();

            Console.WriteLine("正方形の面積は{0}でした", vertical * width);
        }

        private static void TriangleArea()
        {
            Console.WriteLine("三角形の底辺はどのくらいの長さですか？");

            //三角形の底辺の長さの値
            float bottom = InputNumberArea();

            Console.WriteLine("三角形の高さはどのくらいですか？");

            //三角形の高さの値
            float height = InputNumberArea();

            Console.WriteLine("三角形の面積は{0}でした", (bottom * height) / 2);
        }

        private static void CircleArea()
        {
            Console.WriteLine("円形の半径の長さはどのくらいですか");

        　　//円形の半径の値
            float radius = InputNumberArea();

            Console.WriteLine("円形の面積は{0}でした", radius * radius * 3.14);
        }
    }
}
