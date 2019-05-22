using System;
using System.IO;
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
        public string Familiya;     //объявляю переменные
        public string Inichialy;
        public string FullName;
        public string TypeOfWork;
        public int Payment;

        public Stomat(int CardNumber, string Familiya,string Inichialy, string TypeOfWork, int WorkCost, int Payment) //конструктор класса
        {
            this.CardNumber = CardNumber;
            this.Familiya = Familiya;
            this.Inichialy = Inichialy;
            this.TypeOfWork = TypeOfWork;
            this.WorkCost = WorkCost;
            this.Payment = Payment;
        }

        public String getFullName() //произвожу склейку фамилии и инициалов
        {
            string FullName = Familiya + " " + Inichialy;
            return FullName;
        }

        public String getFamiliya() //возвращаю только фамилию для поиска в дальнейшем
        {
            return Familiya;
        }

        public String Zamena () //ставит + или же - в столбе об отметке оплаты
        {
            return this.Payment == 1 ? "+" : "-";
        }

        public String EstDolg () //если нет долга, то пустая колонка, если есть, то возвращает сумму долга
        {
            return this.Payment == 1 ? "0": WorkCost.ToString();
        }

        public String Perevod() //метод,необходимый для выдачи данных в консоль
        {
            return this.Payment == 1 ? WorkCost.ToString() : "0";
        }

        public void writeToFile(BinaryWriter output) //экспорт из файла
        {
            output.Write(this.CardNumber);
            output.Write(this.getFullName());
            output.Write(this.TypeOfWork);
            output.Write(this.WorkCost);
            output.Write(this.Zamena());
            output.Write(this.EstDolg());
        }
    }
}