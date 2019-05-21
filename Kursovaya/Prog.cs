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
        public string Familiya;
        public string Inichialy;
        public string FullName;
        public string TypeOfWork;
        public int Payment;

        public Stomat(int CardNumber, string Familiya,string Inichialy, string TypeOfWork, int WorkCost, int Payment)
        {
            this.CardNumber = CardNumber;
            this.Familiya = Familiya;
            this.Inichialy = Inichialy;
            this.TypeOfWork = TypeOfWork;
            this.WorkCost = WorkCost;
            this.Payment = Payment;
        }

        public string getFullName() //произвожу склейку фамилии и инициалов
        {
            string FullName = Familiya + " " + Inichialy;
            return FullName;
        }

        public string getFamiliya() //возвращаю только фамилию для поиска в дальнейшем
        {
            return Familiya;
        }

        public String Zamena () //ставит + или же пробел в столбе об отметке оплаты
        {
            return this.Payment == 1 ? "+" : "-";
        }

        public String EstDolg () //если нет долга, то пустая колонка, если есть, то возвращает сумму долга
        {
            return this.Payment == 1 ? "0": WorkCost.ToString();
        }

        public string Perevod()
        {
            return this.Payment == 1 ? WorkCost.ToString() : "0";
        }

        public String Peredacha()
        {
            return (CardNumber == -1 )? "" : CardNumber.ToString();
        }
    }
}