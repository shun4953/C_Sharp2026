using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    /// <summary>
    /// パトカーの状況
    /// </summary>
    internal class PoliceCar : BaseCar         
    {
        //緊急走行中か
        protected bool isEmergencyDrive = false;

        //犯人は乗っているか
        protected bool isSuspectApprehended = false;

        //乗っている警官の人数
        protected int numberPoliceOfficers = 0;

        //犯人の罪状
        protected string charges = "";

        /// <summary>
        /// コンストラクト
        /// </summary>
        /// <param name="carName">車の名前</param>
        /// <param name="carMaxSpeed">車の最大スピード</param>
        /// <param name="carColor">車の色</param>
        /// <param name="isEmergencyDrive">緊急走行中であるか</param>
        /// <param name="suspectApprehended">犯人は乗っているのか</param>
        /// <param name="numberPoliceOfficers">車に乗っている警官の人数</param>
        /// <param name="charges">犯人の罪状</param>
        public PoliceCar
              (string carName,
               float carMaxSpeed,
               string carColor,
               bool isEmergencyDrive,
               bool suspectApprehended,
               int numberPoliceOfficers,
               string charges
               ):base(
               carName,
               carMaxSpeed,
               carColor)
        {
            this.isEmergencyDrive = isEmergencyDrive;

            this.isSuspectApprehended = suspectApprehended;

            this.numberPoliceOfficers = numberPoliceOfficers;

            this.charges = charges;
        }

        /// <summary>
        /// パトカーの情報が入ったメソッド
        /// </summary>
        public void PoliceCarStatus()
        {
            //もし現在、緊急走行中ならば
            if(isEmergencyDrive)
            {
                //緊急走行中だと表示する
                Console.WriteLine("現在、緊急走行中です。");
            }
            //もし現在、緊急走行中ではないのなら
            else
            {
                //緊急走行中以外のことをしていると表示する
                Console.WriteLine("現在、緊急走行中ではありません。");
            }

            //緊急走行中に乗っていないのなら
            if(isSuspectApprehended && isEmergencyDrive)
            {
                //まだ逮捕できていないと表示する
                Console.WriteLine("現在追跡中です。");
            }

            //もし犯人が乗っているのなら
            else if (isSuspectApprehended)
            {
                //犯人は乗っていると表示する
                Console.WriteLine("犯人を連行しています。");
            }

            //通常時で乗っていないのなら
            else
            {
                //逮捕していないと表示する
                Console.WriteLine("まだ誰も逮捕していません");
            }

            //車内にいる警官の人数を表示する
            Console.WriteLine("車内には{0}人の警官がいます。", numberPoliceOfficers);
        }

        /// <summary>
        /// 犯人の罪状を明かすメソッド
        /// </summary>
        public void PerpetratorCherges()
        {
            //もし犯人が逮捕されていたなら
            if(isSuspectApprehended)
            {
                //犯人の罪状を明かす
                Console.WriteLine("犯人は{0}で逮捕されました。", charges);
            }
        }
    }
}
