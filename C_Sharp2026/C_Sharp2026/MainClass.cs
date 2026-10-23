using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            /*

            BaseCar basecar = new BaseCar
                                 ("トヨタ",
                                  100.0f,
                                  "シルバー",
                                  true,
                                  48,
                                  "普通くらい",
                                  "レギュラー",
                                  715,
                                  75);

            //車紹介メソッドを呼び出す
            basecar.CarExplanation();
            basecar.CallGasolineRemaining();

            //ガソリンの残量を表示する
            Console.WriteLine("この車のガソリン残量は{0}です。", basecar.GetGasolineRemaining());

            */

            //ここからクラスの復習

            //問題１
            Console.WriteLine("問題１");

            Human human = new Human(163,59,18,100);

            human.DisplayBodyInfo();

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            human.DisplayAge();

            human.GettingOlder();

            human.DisplayAge();

            Console.WriteLine();

            //問題３
            Console.WriteLine("問題３");

            human.CheckBMI();

            Console.WriteLine();

            //問題４
            Console.WriteLine("問題４");

            human.MoveTime();
        }
    }
}
