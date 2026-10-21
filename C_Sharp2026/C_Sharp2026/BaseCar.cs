using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    //
    internal class BaseCar
    {
        //車の名前
        private string name = "";

        //最大時速
        private float maxSpeed = 0.0f;

        //車の色
        private string color = "";

        //車が走っているかどうか
        private bool isDrive = false;

        //馬力
        private float horsePower = 0.0f;

        //車の大きさ
        private string bodySize = "";

        //燃料の種類
        private string gasolineKind = "";

        //車の重さ
        private int Weight = 0;

        //車のガソリンの残量
        private float gasolineFuelLevel = 0.0f;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseCar
              (string carName,
               float carMaxSpeed,
               string carColor,
               bool isCarDrive,
               float carHorsePower,
               string carBodySize,
               string carGasolineKind,
               int carWeight,
               float carGasolineFuelLevel)
        {
            Console.WriteLine("オブジェクトの生成に成功しました");

            name = carName;

            maxSpeed = carMaxSpeed;

            color = carColor;

            isDrive = isCarDrive;

            horsePower = carHorsePower;

            bodySize = carBodySize;

            gasolineKind = carGasolineKind;

            Weight = carWeight;

            gasolineFuelLevel = carGasolineFuelLevel;

            //もしガソリン残量が１００％を超えたのなら
            if (gasolineFuelLevel > 100.0f)
            {
                //１００％にする
                gasolineFuelLevel = 100.0f;
            }
            //もしガソリン残量が０％よりも下回ったのなら
            else if (gasolineFuelLevel < 0)
            {
                //０％にする
                gasolineFuelLevel = 0.0f;
            }
        }

        public void CarExplanation()
        {
            Console.WriteLine("この車の名前は{0}です。", name);

            Console.WriteLine("この車の最大スピードは{0}です。", maxSpeed);

            Console.WriteLine("この車の色は{0}です。", color);

            if (isDrive == true)
            {
                Console.WriteLine("この車は走っています。");
            }
            else
            {
                Console.WriteLine("この車は走っていません。");
            }

            Console.WriteLine("この車の馬力は{0}です。", horsePower);

            Console.WriteLine("この車の大きさは{0}です。", bodySize);

            Console.WriteLine("この車の燃料の種類は{0}です。", gasolineKind);

            Console.WriteLine("この車の重さは{0}です。", Weight);
        }

        /// <summary>
        /// ガソリンの残量を表示するメソッド
        /// </summary>
        public void CallGasolineRemaining()
        {
            Console.WriteLine("この車のガソリン残量は{0}です。",gasolineFuelLevel);
        }

        /// <summary>
        /// ガソリンの残量を入れるメソッド
        /// </summary>
        /// <returns>ガソリンの残量</returns>
        public string GetGasolineRemaining()
        {
            return gasolineFuelLevel + "%";
        }
    }
    //
}
