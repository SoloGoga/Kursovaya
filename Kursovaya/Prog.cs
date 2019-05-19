using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    class Stomat
    {
        public int CardNumber;
        public int WorkCost;

        public string FullName;
        public string TypeOfWork;

        public bool Payment;

        public string Dolg;

        public Stomat(int CardNumber, string FullName, string TypeOfWork, int WorkCost, bool Payment, string Dolg)
        {
            this.CardNumber = CardNumber;

            this.FullName = FullName;

            this.TypeOfWork = TypeOfWork;

            this.WorkCost = WorkCost;

            this.Payment = Payment;

            this.Dolg = Dolg;

        }

        public String Zamena ()
        {
            return this.Payment? "+" : " ";
        }

        public String EstDolg ()
        {
            return this.Payment ? "": WorkCost.ToString();
        }

        public String Peredacha()
        {
            return (CardNumber == -1 )? "" : CardNumber.ToString();
        }

       

        public static Stomat SozdatPustoy(int CardNumber,int WorkCost)
        {
            Stomat pustayaKarta = new Stomat(CardNumber, null, null, WorkCost, false, null);
           
            return pustayaKarta;
        }


    }
}