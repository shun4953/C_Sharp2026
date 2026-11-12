using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class EnumAndSwitch
    {
        public enum DayOfWeek
        {
            MONDAY,   //月曜日
            TUESDAY,  //火曜日
            WEDNESDAY,//水曜日
            THURSDAY, //木曜日
            FRIDAY,   //金曜日
            SATURDAY, //土曜日
            SUNDAY    //日曜日
        }

        //使用例
        private static DayOfWeek today = DayOfWeek.MONDAY;

        //問題１
        //ポケモンのタイプ
        public enum pokemonType
        {
            Normal,  //ノーマルタイプ
            Fire,    //ほのおタイプ
            Water,   //みずタイプ
            Grass,   //くさタイプ
            Electric,//でんきタイプ
            Ice,     //こおりタイプ
            Fight,   //かくとうタイプ
            Poison,  //どくタイプ
            Ground,  //じめんタイプ
            Fly,     //ひこうタイプ
            Psychic, //エスパータイプ
            Bug,     //むしタイプ
            Rock,    //いわタイプ
            Ghost,   //ゴーストタイプ
            Dragon,  //ドラゴンタイプ
            Dark,    //あくタイプ
            Steel,   //はがねタイプ
            Faily    //フェアリータイプ
        }

        //ポケモンのタイプの指定
        private static pokemonType type = pokemonType.Normal;

        //ポケモンのタイプの指定 数バージョン
        private static int typeNumber = (int)pokemonType.Normal;

        private static void Main(string[] args)
        {
            //もし今日が月曜日なら
            if(today == DayOfWeek.MONDAY)
            {
                //月曜日と答える
                Console.WriteLine("今日は月曜日です");
            }

            //もし今日が火曜日なら
            else if (today == DayOfWeek.TUESDAY)
            {
                //火曜日と答える
                Console.WriteLine("今日は火曜日です");
            }

            //もし今日が水曜日なら
            else if (today == DayOfWeek.WEDNESDAY)
            {
                //水曜日と答える
                Console.WriteLine("今日は水曜日です");
            }

            //もし今日が木曜日なら
            else if (today == DayOfWeek.THURSDAY)
            {
                //木曜日と答える
                Console.WriteLine("今日は木曜日です");
            }

            //もし今日が金曜日なら
            else if (today == DayOfWeek.FRIDAY)
            {
                //金曜日と答える
                Console.WriteLine("今日は金曜日です");
            }

            //もし今日が土曜日なら
            else if (today == DayOfWeek.SATURDAY)
            {
                //土曜日と答える
                Console.WriteLine("今日は土曜日です");
            }

            //もし今日が日曜日なら
            else if (today == DayOfWeek.SUNDAY)
            {
                //日曜日と答える
                Console.WriteLine("今日は日曜日です");
            }
            

            switch(today)
            {
                //月曜日
                case DayOfWeek.MONDAY:
                    Console.WriteLine("今日は月曜日です");
                    break;

                //火曜日
                case DayOfWeek.TUESDAY:
                    Console.WriteLine("今日は火曜日です");
                    break;

                //水曜日
                case DayOfWeek.WEDNESDAY:
                    Console.WriteLine("今日は水曜日です");
                    break;

                //木曜日
                case DayOfWeek.THURSDAY:
                    Console.WriteLine("今日は木曜日です");
                    break;

                //金曜日
                case DayOfWeek.FRIDAY:
                    Console.WriteLine("今日は金曜日です");
                    break;

                //土曜日
                case DayOfWeek.SATURDAY:
                    Console.WriteLine("今日は土曜日です");
                    break;

                //日曜日
                case DayOfWeek.SUNDAY:
                    Console.WriteLine("今日は日曜日です");
                    break;
            }

            //

            //問題２
            Console.WriteLine("問題２");

            //ポケモンのタイプを判断するスイッチ
            switch(type)
            {
                //ノーマルタイプ
                case pokemonType.Normal:
                    Console.WriteLine("そのポケモンはノーマルタイプです");
                    break;

                //ほのおタイプ
                case pokemonType.Fire:
                    Console.WriteLine("そのポケモンはほのおタイプです");
                    break;

                //みずタイプ
                case pokemonType.Water:
                    Console.WriteLine("そのポケモンはみずタイプです");
                    break;

                //くさタイプ
                case pokemonType.Grass:
                    Console.WriteLine("そのポケモンはくさタイプです");
                    break;

                //でんきタイプ
                case pokemonType.Electric:
                    Console.WriteLine("そのポケモンはでんきタイプです");
                    break;

                //こおりタイプ
                case pokemonType.Ice:
                    Console.WriteLine("そのポケモンはこおりタイプです");
                    break;

                //かくとうタイプ
                case pokemonType.Fight:
                    Console.WriteLine("そのポケモンはかくとうタイプです");
                    break;

                //どくタイプ
                case pokemonType.Poison:
                    Console.WriteLine("そのポケモンはどくタイプです");
                    break;

                //じめんタイプ
                case pokemonType.Ground:
                    Console.WriteLine("そのポケモンはじめんタイプです");
                    break;

                //ひこうタイプ
                case pokemonType.Fly:
                    Console.WriteLine("そのポケモンはひこうタイプです");
                    break;

                //エスパータイプ
                case pokemonType.Psychic:
                    Console.WriteLine("そのポケモンはエスパータイプです");
                    break;

                //むしタイプ
                case pokemonType.Bug:
                    Console.WriteLine("そのポケモンはむしタイプです");
                    break;

                //いわタイプ
                case pokemonType.Rock:
                    Console.WriteLine("そのポケモンはいわタイプです");
                    break;

                //ゴーストタイプ
                case pokemonType.Ghost:
                    Console.WriteLine("そのポケモンはゴーストタイプです");
                    break;

                //ドラゴンタイプ
                case pokemonType.Dragon:
                    Console.WriteLine("そのポケモンはドラゴンタイプです");
                    break;

                //あくタイプ
                case pokemonType.Dark:
                    Console.WriteLine("そのポケモンはあくタイプです");
                    break;

                //はがねタイプ
                case pokemonType.Steel:
                    Console.WriteLine("そのポケモンははがねタイプです");
                    break;

                //フェアリータイプ
                case pokemonType.Faily:
                    Console.WriteLine("そのポケモンはフェアリータイプです");
                    break;

            }

            //

            //問題３
            Console.WriteLine("問題３");

            //ポケモンのタイプが入っている配列
            string[] typeArray = new string[18] { "ノーマルタイプ", "ほのおタイプ", "みずタイプ", "くさタイプ", "でんきタイプ", "こおりタイプ", "かくとうタイプ", "どくタイプ", "じめんタイプ", "ひこうタイプ", "エスパータイプ", "むしタイプ", "いわタイプ", "ゴーストタイプ", "ドラゴンタイプ", "あくタイプ", "はがねタイプ", "フェアリータイプ" };

            //ポケモンのタイプを教える
            Console.WriteLine("そのポケモンは{0}です",typeArray[typeNumber]);

            
        }
    }
}
