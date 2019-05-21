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
        const int BaseCount = 20;                         //максимальное значение списка
        List<Stomat> Base = new List<Stomat>(BaseCount); // Создание списка

        public Form1()
        {

            InitializeComponent();

            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Егор Ильич", "Удаление зуба", 1000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотеско", "Артем Федорович", "Курсач делает", 100, 1));
            RefreshGrid();

            ToolTip Spravka = new ToolTip(); //Подсказки на кнопки
            Spravka.SetToolTip(AddButton, "Кнопка добавляет информацию о пациенте в базу.");
            Spravka.SetToolTip(SearchNameButt, "Кнопка находит пациента и выдаёт о нём справку, по его ФИО.");
            Spravka.SetToolTip(SearchTypeButt, "Кнопка находит пациента и выдаёт о нём справку, по процедуре, которую он заказывал.");
            Spravka.SetToolTip(SearchDolgButt, "Кнопка находит пациентов, которые не оплатили процедуру, и выдаёт о них справку.");
            Spravka.SetToolTip(DeleteDolgButt, "Кнопка удаляет информацию про пациентов без задолженности.");
            Spravka.SetToolTip(PassButton, "Кнопка на предоставления прав редактирования таблицы, пользователь должен знать пароль, чтобы получить данные права.");
            //Подсказки на остальное (текст боксы и тп.)
            Spravka.SetToolTip(CardNumberNumeric, "Поле для ввода номера карточки пациента в базе.");
            Spravka.SetToolTip(FamiliyaBox, "Поле для ввода ФИО пациента.");
            Spravka.SetToolTip(TypeOfWorkBox, "Поле для ввода вида процедуры, которую назначил стоматолог.");
            Spravka.SetToolTip(CostOfWork, "Стоимость выполненной процедуры.");
            Spravka.SetToolTip(PaymentNumerical, "Оплатил ли пациент процедуру. Да, если оплатил. Нет, если не оплатил.");
            Spravka.SetToolTip(SearchNameTextBox, "Поле для поиска пациента по ФИО.");
            Spravka.SetToolTip(SearchTypeBox, "Поле для поиска пациентов по виду процедуры.");
            Spravka.SetToolTip(PassTextBox, "Поле для получения прав на разрешение редактирования таблицы, для этого введите пароль.");
            Spravka.SetToolTip(Consol, "Консоль данной базы данных, ошибки и успешные действия будут выводиться тут.");
            Spravka.SetToolTip(Tablitca, "База данных о пациентах стоматолога, тут находятся основные сведения про пациентов.");
        }

        private void RefreshGrid() //обновление таблицы
        {
            Tablitca.Rows.Clear();
            foreach (var element in Base)
            {
                Tablitca.Rows.Add
                (
                    element.CardNumber,
                    element.getFullName(),
                    element.TypeOfWork,
                    element.WorkCost,
                    element.Zamena(),
                    element.EstDolg()
                );
            }
        }

        private void AddButton_Click(object sender, EventArgs e) //проверка на заполненность полей
        {
            foreach (var element in Base)
            {
                if (CardNumberNumeric.Value == element.CardNumber)
                {
                    Consol.AppendText("Такой номер карты уже есть!\r\n");
                    return;
                }
            } 
            
            RefreshGrid();
            if (FamiliyaBox.Text.Length == 0 || !Slovo((String)FamiliyaBox.Text))
            {
                Consol.AppendText("Проверьте правильность написания фамилии!\r\n");
            }
            else if (TypeOfWorkBox.Text.Length == 0 || !Slovo((String)TypeOfWorkBox.Text))
            {
                Consol.AppendText("Проверьте, выбрали ли вы услугу!\r\n");
            }
            else if (NameAndOtchestvo.Text.Length == 0 || !Slovo((String)NameAndOtchestvo.Text))
            {
                Consol.AppendText("Проверьте правильность написания инициалов!\r\n");
            }
            else
            {
                Base.Add(new Stomat((int)CardNumberNumeric.Value, FamiliyaBox.Text, NameAndOtchestvo.Text, TypeOfWorkBox.Text, (int)CostOfWork.Value, (int)PaymentNumerical.Value));
                Consol.Clear();
                Consol.AppendText("Данные успешно сохранены в таблице!\r\n");
            }
            RefreshGrid();
        }

        public bool Slovo(string mas) //проверка является ли введенное словом
        {
            foreach (char s in mas)
            {
                if (!char.IsLetter(s) && s != ' ' && s != '-') return false;
            }
            return true;
        }

        private void Tablitca_CellContentClick(object sender, DataGridViewCellEventArgs e) //удаление пациентов
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Стереть данные?", "Карточка №" + (e.RowIndex + 1), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Base.Remove(Base.ElementAt(e.RowIndex));
                        RefreshGrid();
                        Consol.AppendText("Данные стерты (Карточка № " + (e.RowIndex + 1) + ")\r\n");
                    }
                    else Consol.AppendText("Отмена перезаписи\r\n");
                }
            }
        }

        private void SearchDolgButt_Click(object sender, EventArgs e) //поиск должников
        {
            int counter = 0;
            for (int i = 0; i < BaseCount; i++)
            {
                if (Base[i].Payment == 0)
                {
                    Consol.AppendText("№ карточки: " + Base[i].CardNumber.ToString() + "\t");
                    Consol.AppendText("Ф.И.О. клиента: " + Base[i].getFullName() + "\t");
                    Consol.AppendText("Вид проделанной работы: " + Base[i].TypeOfWork + "\r\n");
                    Consol.AppendText("Стоимость: " + Base[i].WorkCost + "\r\n");
                    Consol.AppendText("Задолженность: " + Base[i].WorkCost + "\r\n");
                    counter++;
                }
            }
            if (counter == 0) Consol.AppendText("Поиск не дал результатов.\r\n");
        }

        string Parol = "admin";                                    // задаю пароль
        private void PassButton_Click(object sender, EventArgs e) //пароль и все дела
        {
            if (PassTextBox.Text == Parol)
            {
                Consol.Clear();
                Consol.AppendText("Чего желает мой повелитель?");
                Tablitca.AllowUserToDeleteRows = true;
                Tablitca.AllowUserToAddRows = true;
                Tablitca.AllowUserToResizeRows = true;
                Tablitca.AllowUserToResizeColumns = true;
                Tablitca.AllowUserToOrderColumns = true;
                Tablitca.ReadOnly = false;
            }
            else
            {
                Consol.AppendText("Пароль не верный!\r\n");
                PassTextBox.Text = "";
            }
        }

        private void SearchNameButt_Click(object sender, EventArgs e) //поиск по фамилии
        {
            Consol.Clear();
                if (!Slovo(SearchNameTextBox.Text))
                {
                    Consol.AppendText("Проверьте правильность написания фамилии!\r\n");
                    return;
                }
                    Consol.AppendText("Поиск по фамилии:\r\n");
                int counter = 0;
                for (int i = 0; i < BaseCount; i++)
                {
                    if (Base[i].getFamiliya().Equals(SearchNameTextBox.Text))
                    {
                        
                        Consol.AppendText("№ карточки: " + Base[i].CardNumber.ToString() + "\t");
                        Consol.AppendText("Ф.И.О. клиента: " + Base[i].getFullName() + "\t");
                        Consol.AppendText("Вид проделанной работы: " + Base[i].TypeOfWork + "\r\n");
                        Consol.AppendText("Стоимость: " + Base[i].WorkCost + "\r\n");
                        Consol.AppendText("Оплата: " + Base[i].Perevod() + "\r\n");
                        Consol.AppendText("Должен врачу: " + Base[i].EstDolg() + "\r\n");
                        counter++;
                    }
                }
                if (counter == 0) Consol.AppendText("Поиск не дал результатов.\r\n");
        }

        private void ConsoleClear_Click(object sender, EventArgs e) //очистка консоли
        {
            Consol.Clear();
        }

        private void DeleteDolgButt_Click(object sender, EventArgs e) //удалить всех без задолженности
        {
            
        }

        private void SearchTypeButt_Click(object sender, EventArgs e) //поиск по виду работы
        {
            Consol.Clear();
            if (!Slovo(SearchNameTextBox.Text))
            {
                Consol.AppendText("Проверьте правильность написания вида работы!\r\n");
                return;
            }
            Consol.AppendText("Поиск по виду работы:\r\n");
            int counter = 0;
            for (int i = 0; i < BaseCount; i++)
            {
                if (Base[i].TypeOfWork.Equals(SearchTypeBox.Text))
                {
                    Consol.AppendText("№ карточки: " + Base[i].CardNumber.ToString() + "\t");
                    Consol.AppendText("Ф.И.О. клиента: " + Base[i].getFullName() + "\t");
                    Consol.AppendText("Вид проделанной работы: " + Base[i].TypeOfWork + "\r\n");
                    Consol.AppendText("Стоимость: " + Base[i].WorkCost + "\r\n");
                    Consol.AppendText("Оплата: " + Base[i].Perevod() + "\r\n");
                    Consol.AppendText("Должен врачу: " + Base[i].EstDolg() + "\r\n");
                    counter++;
                }
            }

            if (counter == 0) Consol.AppendText("Поиск не дал результатов.\r\n");
        }
    }
}