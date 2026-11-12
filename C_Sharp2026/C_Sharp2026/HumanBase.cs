using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class HumanBase
    {
        //年齢
        protected int age = 0;

        //身長
        protected float height = 0.0f;

        //誕生日
        protected string birthday = "";

        /// <summary>
        /// コンストラクト
        /// </summary>
        /// <param name="age">年齢</param>
        /// <param name="height">身長</param>
        /// <param name="birthday">誕生日</param>
        public HumanBase
              (int age,
               float height,
               string birthday)
        {
            this.age = age;

            this.height = height;

            this.birthday = birthday;
        }
    }
}
