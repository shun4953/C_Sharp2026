using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class HumanYaegashi : HumanBase
    {
        //八重樫先生の年齢
        protected string yaegasiAge = "";

        /// <summary>
        /// コンストラクト
        /// </summary>
        /// <param name="yaegasiAge">八重樫先生の年齢</param>
        /// <param name="height">身長</param>
        /// <param name="birthday">誕生日</param>
        public HumanYaegashi
              (string yaegasiAge,
               float height,
               string birthday
               ):base(
               0,
               height,
               birthday)
        {
            this.yaegasiAge = yaegasiAge;
        }

        /// <summary>
        /// 八重樫先生の自己紹介を表示するメソッド
        /// </summary>
        public void yaegasiSelfIntroduction()
        {
            Console.WriteLine(yaegasiAge);

            Console.WriteLine("{0}m",height);

            Console.WriteLine(birthday);

        }
    }
}
