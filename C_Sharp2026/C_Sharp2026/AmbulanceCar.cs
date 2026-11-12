using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    /// <summary>
    /// 救急車の性能
    /// </summary>
    internal class AmbulanceCar : BaseCar
    {
        //緊急搬送中か？
        private bool isEmergencyTransport = false;

        //搬送先の病院の名前
        private string hospitalName = "";

        //患者の名前
        private string patientName = "";

        /// <summary>
        /// コンストラクト
        /// </summary>
        /// <param name="carName">車の名前</param>
        /// <param name="carMaxSpeed">車の最大速度</param>
        /// <param name="carColor">車の色</param>
        public AmbulanceCar
              (string carName,
               float carMaxSpeed,
               string carColor,
               bool isEmergencyTransport,
               string hospitalName,
               string patientName
               ) :base(
               carName,
               carMaxSpeed,
               carColor)
        {
            this.isEmergencyTransport = isEmergencyTransport;
            this.hospitalName = hospitalName;
            this.patientName = patientName;
        }
        public void CallPatientInformation()
        {
            if(isEmergencyTransport)
            {
                Console.WriteLine("患者のなまえは{0}",patientName);

                Console.WriteLine("現在{0}に向かっております。",hospitalName);
            }
            else
            {
                Console.WriteLine("今は患者を乗せていません。");
            }
        }

        

        
    }
}
