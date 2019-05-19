using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        const int BaseCount = 30;                           //максимальное значение списка
        List <Stomat> Base = new List <Stomat> (BaseCount); // Создание списка

        public Form1()
        {

            InitializeComponent();
            
            int spaceCounter = 0;

            
/*
            while (Base.Count < BaseCount)
            {
                Stomat pustayaKarta = Stomat.SozdatPustoy(spaceCounter + 1, spaceCounter + 1);
                Base.Add(pustayaKarta);
                spaceCounter++;
            }
*/
            Base.Add(new Stomat(Base.Count + 1, "Дудин Егор Ильич", "Удаление зуба", 1000, true, "0"));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско Артем Федорович", "Курсач делает", 100, false, "100"));

            foreach (var element in Base)
            {
                Tablitca.Rows.Add
                (
                    element.CardNumber,
                    element.FullName,
                    element.TypeOfWork,
                    element.WorkCost,
                    element.Zamena(),
                    element.EstDolg()
                );
                spaceCounter++;
            }

            ToolTip Spravka = new ToolTip(); //Подсказки на кнопки

            Spravka.SetToolTip(AddButton, "Кнопка добавляет информацию о пациенте в базу.");
            Spravka.SetToolTip(SearchNameButt, "Кнопка находит пациента и выдаёт о нём справку, по его ФИО.");
            Spravka.SetToolTip(SearchTypeButt, "Кнопка находит пациента и выдаёт о нём справку, по процедуре, которую он заказывал.");
            Spravka.SetToolTip(SearchDolgButt, "Кнопка находит пациентов, которые не оплатили процедуру, и выдаёт о них справку.");
            Spravka.SetToolTip(DeleteDolgButt, "Кнопка удаляет информацию про пациентов без задолженности.");
            Spravka.SetToolTip(PassButton, "Кнопка на предоставления прав редактирования таблицы, пользователь должен знать пароль, чтобы получить данные права.");
            //Подсказки на остальное (текст боксы и тп.)
            Spravka.SetToolTip(CardNumber, "Поле для ввода номера карточки пациента в базе.");
            Spravka.SetToolTip(FIO, "Поле для ввода ФИО пациента.");
            Spravka.SetToolTip(TypeOfWork, "Поле для ввода вида процедуры, которую назначил стоматолог.");
            Spravka.SetToolTip(CostOfWork, "Стоимость выполненной процедуры.");
            Spravka.SetToolTip(Payment, "Оплатил ли пациент процедуру. Да, если оплатил. Нет, если не оплатил.");
            Spravka.SetToolTip(SearchNameTextBox, "Поле для поиска пациента по ФИО.");
            Spravka.SetToolTip(SearchType, "Поле для поиска пациентов по виду процедуры.");
            Spravka.SetToolTip(PassTextBox, "Поле для получения прав на разрешение редактирования таблицы, для этого введите пароль.");
            Spravka.SetToolTip(Consol, "Консоль данной базы данных, ошибки и успешные действия будут выводиться тут.");
            Spravka.SetToolTip(Tablitca, "База данных о пациентах стоматолога, тут находятся основные сведения про пациентов.");
        }

        private void AddButton_Click(object sender, EventArgs e) //проверка на заполненность полей
        {
            if (FIO.Text.Length == 0 || !Slovo((String)FIO.Text))
            {
                Consol.AppendText("Проверьте правильность написания ФИО!\r\n");
            }

            else if  (TypeOfWork.Text.Length == 0 || !Slovo((String)TypeOfWork.Text))
            {
               Consol.AppendText("Проверьте, выбрали ли вы услугу!\r\n");
            }

            else
            {
                Consol.Clear();
                Consol.AppendText("Данные успешно сохранены в таблице!\r\n");
            }

        }

        public bool Slovo(string mas) //проверка является ли введенное словом
        {
            foreach (char s in mas)
            {
                if (!char.IsLetter(s) && s != ' ' && s != '-') return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Tablitca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Стереть данные?", "Карточка №" + (e.RowIndex + 1), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        VstavVTablitcuRyad(Stomat.SozdatPustoy(e.RowIndex + 1, e.RowIndex + 1));
                        Consol.AppendText("Данные стерты (Карточка № " + (e.RowIndex + 1) + ")\r\n");
                    }
                    else Consol.AppendText("Отмена перезаписи\r\n");
                }
            }
        }

        private void VstavVTablitcuRyad(Stomat card)
        {
            Base.RemoveAt(card.CardNumber - 1);
            Base.Insert(card.CardNumber - 1, card);

            Tablitca.Rows.RemoveAt(card.CardNumber - 1);
            Tablitca.Rows.Insert
            (
                card.CardNumber - 1,
                card.FullName,
                card.TypeOfWork,
                card.WorkCost,
                card.Zamena(),
                card.EstDolg()
            );
        }
    }
}
