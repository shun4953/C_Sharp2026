using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class HumanSeki : HumanBase
    {
        //関先生の身長
        protected string sekiHeight;

        /// <summary>
        /// コンストラクト
        /// </summary>
        /// <param name="age">年齢</param>
        /// <param name="sekiHeight">関先生の身長</param>
        /// <param name="birthday">誕生日</param>
        public HumanSeki
              (int age,
               string sekiHeight,
               string birthday
               ) : base(
               age,
               0,
               birthday)
        {
            this.sekiHeight = sekiHeight;
        }

        /// <summary>
        /// 関先生の自己紹介を表示するメソッド
        /// </summary>
        public void sekiSelfIntroduction()
        {
            Console.WriteLine("{0}歳",age);

            Console.WriteLine(sekiHeight);

            Console.WriteLine(birthday);

        }
    }
}
