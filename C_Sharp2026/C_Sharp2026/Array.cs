using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class Array
    {
        /*
        private static void Main(string[] args)
        {
            //
            int[] array = new int[5] { 1, 3, 5, 7, 9 };
            int a = array[0];
            Console.WriteLine("配列から取り出したaは{0}です。",a);

            int b = array.Length;
            Console.WriteLine("配列の長さは{0}です。",b);
            //

            //問題１
            int[] array = new int[5] { 0, 1, 2, 3, 4};

            int a = array[0] * 5;

            int b = array[1] * 5;

            int c = array[2] * 5;

            int d = array[3] * 5;

            int e = array[4] * 5;

            Console.WriteLine("配列の数値を五倍にしたときの数値は以下の通りです");

            Console.WriteLine("{0}、{1}、{2}、{3}、{4}",a,b,c,d,e);

            //問題２
            string[] namelist = new string[24] { "アカマ レオン", "アダチ カツマ", "オオミヤ　タスク", "カミヤマ　ハル", "サイドプラナプトラ", "サイモト　マサキ", "サトウ　コウユウ", "サトウ　ツバサ", "スガワラ　ナオタロウ", "タカハシ　コウスケ", "タカハシ　ココロ", "タカハシ　リュウ", "タカハシ　レオ", "ナガタニ　ラタポン", "ハコザキ　ヒカル", "ハタケヤマ　ケンゴ", "ヒナタ　アキラ", "ミヤカワ　シュンタ", "モウリ　ユウト", "ヤマザキ　シュンキ", "ヤマナカ　ヒロト", "ヤマモト　シュンノスケ", "ワタナベ　カイリ", "ササキ　アヤノ" };

            Console.WriteLine("番号を入力してください");

            int number = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(namelist[number] + "さん");
            Console.WriteLine("{0}さん test", namelist[number]);

            if(number <= 23)
            {
                Console.WriteLine("男の子です");
            }
            else
            {
                Console.WriteLine("女の子です");
            }
            //

            //問題３
            string[] namelist = new string[24] { "１番　　アカマ レオン", "２番　　アダチ カツマ", "３番　　オオミヤ　タスク", "４番　　カミヤマ　ハル", "５番　　サイドプラナプトラ", "６番　　サイモト　マサキ", "７番　　サトウ　コウユウ", "８番　　サトウ　ツバサ", "９番　　スガワラ　ナオタロウ", "１０番　タカハシ　コウスケ", "１１番　タカハシ　ココロ", "１２番　タカハシ　リュウ", "１３番　タカハシ　レオ", "１４番　ナガタニ　ラタポン", "１５番　ハコザキ　ヒカル", "１６番　ハタケヤマ　ケンゴ", "１７番　ヒナタ　アキラ", "１８番　ミヤカワ　シュンタ", "１９番　モウリ　ユウト", "２０番　ヤマザキ　シュンキ", "２１番　ヤマナカ　ヒロト", "２２番　ヤマモト　シュンノスケ", "２３番　ワタナベ　カイリ", "２４番　ササキ　アヤノ" };

            int number = 0;

            Console.WriteLine("<変更前>");

            for (int numberlist = 1; numberlist <= 24; numberlist++)
            {
                Console.WriteLine(namelist[number]);
                number++;
            }

            Console.WriteLine("入れ替えたい番号を入力してください");

            int Replacementα = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("どこの番号と入れ替えたいですか？");

            int Replacementβ = int.Parse(Console.ReadLine()) - 1;

            if (Replacementα <= -1 || Replacementα >= 24 || Replacementβ <= -1 || Replacementβ >= 24)
            {
                Console.WriteLine("不正な出席番号です");

                Console.WriteLine("やりなおしてください");
            }
            else
            {
                string shelter = namelist[Replacementα];

                namelist[Replacementα] = namelist[Replacementβ];

                namelist[Replacementβ] = shelter;

                number = 0;

                Console.WriteLine("<変更後>");

                for (int numberlist = 1; numberlist <= 24; numberlist++)
                {
                    Console.WriteLine(namelist[number]);
                   number = number + 1;
                }
            }
        }
        */
    }
}
