using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class Human
    {
        //身長
        private int height = 0;

        //体重
        private int weight = 0;

        //年齢
        private int age = 0;

        //何キロ分移動するか
        private int km = 0;
        public Human
              (int humanHeight,
               int humanWeight,
               int humanAge,
               int humanKm)
        {
            //身長を受け取る
            height = humanHeight;

            //体重を受け取る
            weight = humanWeight;

            //年齢を受け取る
            age = humanAge;

            //移動する距離を受け取る
            km = humanKm;
        }

        /// <summary>
        /// 身長と体重を表示するメソッド
        /// </summary>
        public void DisplayBodyInfo()
        {
            Console.WriteLine("私の身長は{0}cmで体重は{1}kgです", height, weight);
        }

        /// <summary>
        /// 年を表示するメソッド
        /// </summary>
        public void DisplayAge()
        {
            Console.WriteLine("私の年齢は{0}です", age);
        }

        /// <summary>
        /// 年を取らせるメソッド
        /// </summary>
        /// <returns>年を取った後の年齢</returns>
        public int GettingOlder()
        {
            Console.WriteLine("年を取らせます");

            //年を取らせる
            return age++;
        }

        /// <summary>
        /// BMIを計算するメソッド
        /// </summary>
        public void CheckBMI()
        {
            //センチメートル基準をメートル基準に変えた身長
            float meterHeight = height / 100.0f;

            //BMI(小数点第三位を四捨五入する)
            float bmi = MathF.Round( weight / (meterHeight * meterHeight),2);

            Console.WriteLine("あなたのBMIは{0}です", bmi);

            //体系を判定する
            CheckPhysique(bmi);
        }

        /// <summary>
        /// 体系を判定するメソッド
        /// </summary>
        /// <param name="bmi">BMI</param>
        private void CheckPhysique(float bmi)
        {
            //もしbmiが18.5よりも低いなら
            if (bmi < 18.5f)
            {
                //やせ型と表示する
                Console.WriteLine("やせ型");
            }
            //もし前の条件が外れたかつ、bmiが25よりも少ないのなら
            else if (bmi < 25.0f)
            {
                //普通体系と表示する
                Console.WriteLine("普通");
            }
            //もし前の条件が外れたかつ、bmiが30より少ないのなら
            else if (bmi < 30.0f)
            {
                //軽度の肥満と表示する
                Console.WriteLine("ちょっと肥満");
            }
            //もし前の条件が外れたかつ、bmiが35より少ないのなら
            else if (bmi < 35.0f)
            {
                //肥満と表示する
                Console.WriteLine("肥満");
            }
            //もし前の条件が外れたかつ、bmiが40より少なのなら
            else if (bmi < 40.0f)
            {
                //重度の肥満と表示する
                Console.WriteLine("かなり肥満");
            }
            //もしすべての条件が外れたのなら
            else
            {
                //力士(?)と表示する
                Console.WriteLine("力士");
            }
        }

        public void MoveTime()
        {
            //歩いた時の時速
            float walkKmH = ((height * 110) * 60)/100000;

            //走った時の時速
            float runKmH = (((height * 1.15f ) * 170) * 60) /100000;

            //歩いた場合にかかる時間(小数第一位まで表示)
            float arrivalW = MathF.Round(km / walkKmH,1);

            //走った場合にかかる時間(小数第一位まで表示)
            float arrivalR = MathF.Round(km / runKmH,1);

            Console.WriteLine("私が歩いた時の時速は{0}Km/hで、走った時の時速は{1}km/hです", MathF.Round(walkKmH, 1), MathF.Round(runKmH, 1));

            Console.WriteLine("もし目的地が{0}km先にあった場合、わたしなら徒歩で{1}時間、ランニングで{2}時間でたどり着けます",km,arrivalW,arrivalR);
        }
        
    }
}
