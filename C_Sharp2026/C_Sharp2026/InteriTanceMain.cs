using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp2026
{
    internal class InteriTanceMain
    {
        private static void Main(string[] args)
        {
            /*
            AmbulanceCar ambulanceCar = new AmbulanceCar("救急車", 180.0f, "赤と白", true, "仙台総合病院", "関先生");

            ambulanceCar.CarExplanation();
            ambulanceCar.CallPatientInformation();
            //

            //問題１
            Console.WriteLine("問題１");

            PoliceCar policecar = new PoliceCar("パトカー", 180, "白と黒", false, true, 2, "公務執行妨害");

            policecar.CarExplanation();

            policecar.PoliceCarStatus();

            Console.WriteLine();

            //問題２
            Console.WriteLine("問題２");

            policecar.PerpetratorCherges();

            Console.WriteLine();

            */

            //問題３
            Console.WriteLine("問題３");

            Console.WriteLine();

            HumanYaegashi humanYaegashi = new HumanYaegashi("関先生と同い年", 1.8f, "平成９年５月２７日生まれ");

            HumanSeki humanSeki = new HumanSeki(27, "リンゴ三個分", "１９９７年８月２８日生まれ");

            Console.WriteLine("八重樫先生：");

            humanYaegashi.yaegasiSelfIntroduction();

            Console.WriteLine();

            Console.WriteLine("関先生：");

            humanSeki.sekiSelfIntroduction();
        }
    }
}
