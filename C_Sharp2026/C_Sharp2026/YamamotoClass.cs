using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class YamamotoClase
    {
        //名前
        private string name = "";

        //年齢
        private int age = 0;

        //生年月日
        private int birthDate =0;

        //身長
        private float height = 0.0f;

        //趣味
        private string hobby = "";

        //得意なこと
        private string strengths = "";

        //好きな食べ物
        private string favoriteFood = "";

        //好きな動物
        private string favoriteAnimal = "";

        //好きなゲーム
        private string favoriteGames = "";

        //好きなゲームジャンル
        private string favoriteGamesGenres = "";

        //苦手なゲームジャンル
        private string weakGamesGenres = "";

        //今後やりたいゲーム
        private string futurePlayGames = "";

        //将来の夢
        private string futureDreams = "";

        //生年月日の年
        private int year = 0;

        //生年月日の月
        private int month = 0;

        //生年月日の日
        private int day = 0;

        //現在
        public DateTime now = DateTime.Now;

        //現在の年
        private int nowYear = DateTime.Now.Year;

        //現在の月
        private int nowMonth = DateTime.Now.Month;

        //現在の日
        private int nowDay = DateTime.Now.Day;

        public YamamotoClase
              (string myName,
               int myBarthDate,
               float myHeight,
               string myStrengths,
               string myFavoriteFood,
               string myFavoriteAnimal,
               string myFavoriteGames,
               string myFavoriteGamesGenres,
               string myWeakGamesGenres,
               string myFutureGames,
               string myFutureDreams)

        {
            name = myName;

            birthDate = myBarthDate;

            //生年月日の年を求めている
            year = myBarthDate / 10000;

            //生年月日の月を求めている
            month = (myBarthDate - year * 10000) / 100;

            //生年月日の日を求めている
            day = myBarthDate - (year * 10000 + month * 100);

            //もし誕生日の日を過ぎているのなら
            if (nowMonth >= month && nowDay >= day) 
            {
                //誕生日後の年齢にする
                age = nowYear - year;
            }
            //誕生日を迎えていないなら
            else
            {
                //誕生日前の年齢にする
                age = (nowYear - year) - 1;
            }

            height = myHeight;

            strengths = myStrengths;

            favoriteFood = myFavoriteFood;

            favoriteAnimal = myFavoriteAnimal;

            favoriteGames = myFavoriteGames;

            favoriteGamesGenres = myFavoriteGamesGenres;

            weakGamesGenres = myWeakGamesGenres;

            futurePlayGames = myFutureGames;

            futureDreams = myFutureDreams;
        }
    }
}
