using System;
using System.IO;
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
        const int BaseCount = 25;                         //максимальное значение списка

        List<Stomat> Base = new List<Stomat>(BaseCount); // Создание списка

        private static string path = Environment.CurrentDirectory + "/StomatBase.kurs"; //указываю путь сохранения (будет сохраняться в той папке, где находится приложение

        public Form1()
        {

            InitializeComponent();
            //искусственно забиваю таблицу
            Base.Add(new Stomat(Base.Count + 1, "Дудин", "Гога Афанасьевич", "Удаление зуба", 1400, 0));
            Base.Add(new Stomat(Base.Count + 1, "Коваленко", "Владимир Федотович", "Пломба", 320, 1));
            Base.Add(new Stomat(Base.Count + 1, "Кудрин", "Мстислав Юрьевич", "Удаление нерва", 2700, 1));
            Base.Add(new Stomat(Base.Count + 1, "Жан", "Пьер Крузо", "Пломба", 5100, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фотескур", "Артем Игоревич", "Осмотр", 150, 1));
            Base.Add(new Stomat(Base.Count + 1, "Варвар", "Руслан Сергеевич", "Протезирование", 3700, 0));
            Base.Add(new Stomat(Base.Count + 1, "Костюшкин", "Игорь Павлович", "Удаление зуба", 2300, 1));
            Base.Add(new Stomat(Base.Count + 1, "Камара", "Максим Мантонов", "Осмотр", 120, 1));
            Base.Add(new Stomat(Base.Count + 1, "Ветровор", "Сергей Петрович", "Пломба", 1900, 0));
            Base.Add(new Stomat(Base.Count + 1, "Панкратор", "Егор Евгеньевич", "Удаление зуба", 1700, 0));
            Base.Add(new Stomat(Base.Count + 1, "Метроном", "Богдан Титомирович", "Осмотр", 190, 1));
            Base.Add(new Stomat(Base.Count + 1, "Мукоторг", "Багратион Федотович", "Отбеливание", 2000, 0));
            Base.Add(new Stomat(Base.Count + 1, "Гидромед", "Петр Константинович", "Удаление зуба", 1500, 1));
            Base.Add(new Stomat(Base.Count + 1, "Журавлев", "Артем Николаевич", "Пломба", 110, 1));
            Base.Add(new Stomat(Base.Count + 1, "Станков", "Никита Андреевич", "Протезирование", 5300, 0));
            Base.Add(new Stomat(Base.Count + 1, "Рукавов", "Святослав Олегович", "Удаление зуба", 1900, 1));
            Base.Add(new Stomat(Base.Count + 1, "Земля", "Артем Федорович", "Отбеливание", 170, 1));
            Base.Add(new Stomat(Base.Count + 1, "Рукомол", "Жак Пьеро", "Удаление зуба", 1600, 0));
            Base.Add(new Stomat(Base.Count + 1, "Фирма", "Владислав Кириллович", "Удаление зуба", 1800, 1));
            Base.Add(new Stomat(Base.Count + 1, "Нос", "Евгений Тихомирович", "Отбеливание", 130, 1));

            RefreshGrid();
        }

        private void RefreshGrid() //обновление таблицы
        {
            Tablitca.Rows.Clear();
            foreach (var element in Base)
            {
                Tablitca.Rows.Add
                (
                    element.CardNumber,         //присвоение элементов в таблицу
                    element.getFullName(),
                    element.TypeOfWork,
                    element.WorkCost,
                    element.Zamena(),
                    element.EstDolg()
                );
            }
        }

        private void AddButton_Click(object sender, EventArgs e) //проверка на заполненность полей + добавление, если прошли все проверки успешно
        {
            foreach (var element in Base)
            {
                if (CardNumberNumeric.Value == element.CardNumber) //сравниваю номер, который хочет добавить пользователь с имеющимися
                {
                    Consol.Clear();
                    Consol.AppendText("Такой номер карты уже есть!\r\n");
                    return;
                }
            } 
            RefreshGrid();

            if (FamiliyaBox.Text.Length == 0 || !Slovo((String)FamiliyaBox.Text)) //проверка поля "фамилия"
            {
                Consol.AppendText("Проверьте правильность написания фамилии!\r\n");
            }
            else if (TypeOfWorkBox.Text.Length == 0 || !Slovo((String)TypeOfWorkBox.Text)) //проверка поля "вид услуги"
            {
                Consol.AppendText("Проверьте, выбрали ли вы услугу!\r\n");
            }
            else if (NameAndOtchestvo.Text.Length == 0 || !Slovo((String)NameAndOtchestvo.Text)) //проверка поля "инициалы"
            {
                Consol.AppendText("Проверьте правильность написания инициалов!\r\n");
            }
            else
            {
                Base.Add(new Stomat((int)CardNumberNumeric.Value, FamiliyaBox.Text, NameAndOtchestvo.Text, TypeOfWorkBox.Text, (int)CostOfWork.Value, (int)PaymentNumerical.Value)); //запись
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
            {                            //"иду" к 6 столбику (6-й он, если считать с 0)
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Стереть данные?", "Карточка №" + (e.RowIndex + 1), MessageBoxButtons.YesNo) == DialogResult.Yes) // вызов диалогового окна
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
            Consol.Clear();
            int counter = 0;
            for (int i = 0; i < BaseCount; i++)
            {
                if (Base[i].Payment == 0) // выдача информации про должников
                {
                    Consol.AppendText("№ карточки: " + Base[i].CardNumber.ToString() + "\t");
                    Consol.AppendText("Ф.И.О. пациента: " + Base[i].getFullName() + "\t");
                    Consol.AppendText("Вид проделанной работы: " + Base[i].TypeOfWork + "\r\n");
                    Consol.AppendText("Стоимость: " + Base[i].WorkCost + "\r\n");
                    Consol.AppendText("Задолженность: " + Base[i].WorkCost + "\r\n" + "\r\n");
                    counter++;
                }
            }
            if (counter == 0) Consol.AppendText("Поиск не дал результатов.\r\n");
        }

        string Password = "admin";                                           // задаю пароль

        private void PassButton_Click(object sender, EventArgs e)          //проверка пароля, при правильном пароле все элементы 
        {                                                                 //становятся видимыми
            if (PassTextBox.Text == Password)
            {
                Consol.Clear();
                Consol.AppendText("Теперь вам доступно редактирование базы, приятной работы.\r\n");
                Tablitca.Visible = true;
                AddButton.Visible = true;
                SearchNameButt.Visible = true;
                SearchTypeButt.Visible = true;
                SearchDolgButt.Visible = true;
                DeleteDolgButt.Visible = true;
                CardNumberNumeric.Visible = true;
                FamiliyaBox.Visible = true;
                NameAndOtchestvo.Visible = true;
                TypeOfWorkBox.Visible = true;
                CostOfWork.Visible = true;
                PaymentNumerical.Visible = true;
                SearchNameTextBox.Visible = true;
                SearchTypeBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = false;
                label10.Visible = true;
                label11.Visible = true;
                PassTextBox.Visible = false;
                PassButton.Visible = false;
                ImportButt.Visible = true;
                ExportButt.Visible = true;
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
                if (Base[i].getFamiliya().Contains(SearchNameTextBox.Text)) //выдача результатов при совпадении
                {

                    Consol.AppendText("№ карточки: " + Base[i].CardNumber.ToString() + "\t");
                    Consol.AppendText("Ф.И.О. пациента: " + Base[i].getFullName() + "\t");
                    Consol.AppendText("Вид проделанной работы: " + Base[i].TypeOfWork + "\r\n");
                    Consol.AppendText("Стоимость: " + Base[i].WorkCost + "\r\n");
                    Consol.AppendText("Оплата: " + Base[i].Perevod() + "\r\n");
                    Consol.AppendText("Должен врачу: " + Base[i].EstDolg() + "\r\n" + "\r\n");
                    counter++;
                }
            }
            if (counter == 0)
            {
                Consol.AppendText("Поиск не дал результатов.\r\n"); 
            }
        }

        private void ConsoleClear_Click(object sender, EventArgs e) //очистка консоли
        {
            Consol.Clear();
        }

        private void DeleteDolgButt_Click(object sender, EventArgs e) //удалить всех без задолженности
        {
            Consol.Clear();
            int counter = 0;
            for (int i = 0; i < Base.Count; i++)
            {
                if (Base[i].Payment == 1) //если есть совпадения, будет удалять оплативших
                {
                    Base.Remove(Base[i]);
                    RefreshGrid();
                    counter++;
                }
            }
            Consol.AppendText("Удалены все пациенты без задолженности\r\n");

            if (counter == 0)
            {
                Consol.Clear();
                Consol.AppendText("Поиск не дал результатов.\r\n");
            }
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
                if (Base[i].TypeOfWork.Contains(SearchTypeBox.Text)) //информация по найденным пациентам
                {
                    Consol.AppendText("№ карточки: " + Base[i].CardNumber.ToString() + "\t");
                    Consol.AppendText("Ф.И.О. пациента: " + Base[i].getFullName() + "\t");
                    Consol.AppendText("Вид проделанной работы: " + Base[i].TypeOfWork + "\r\n");
                    Consol.AppendText("Стоимость: " + Base[i].WorkCost + "\r\n");
                    Consol.AppendText("Оплата: " + Base[i].Perevod() + "\r\n");
                    Consol.AppendText("Должен врачу: " + Base[i].EstDolg() + "\r\n");
                    counter++;
                }
            }

            if (counter == 0) Consol.AppendText("Поиск не дал результатов.\r\n");
        }

        private void Form1_Load(object sender, EventArgs e) //при загрузке формы все это заработает
        {
            ToolTip Spravka = new ToolTip(); //Подсказки на кнопки
            Spravka.SetToolTip(ConsoleClear, "Очистка консоли.");
            Spravka.SetToolTip(AddButton, "Кнопка добавляет информацию о пациенте в информационную базу.");
            Spravka.SetToolTip(SearchNameButt, "Кнопка находит пациента и выдаёт о нём справку, по его фамилии.");
            Spravka.SetToolTip(SearchTypeButt, "Кнопка находит пациента и выдаёт о нём справку, по процедуре, которую он заказывал.");
            Spravka.SetToolTip(SearchDolgButt, "Кнопка находит пациентов, которые не оплатили процедуру, и выдаёт о них справку.");
            Spravka.SetToolTip(DeleteDolgButt, "Кнопка удаляет информацию про пациентов без задолженности.");
            Spravka.SetToolTip(PassButton, "Кнопка на предоставления прав редактирования таблицы, пользователь должен знать пароль, чтобы получить данные права.");
            Spravka.SetToolTip(ImportButt, "Кнопка импорта из файла информации в базу.");
            Spravka.SetToolTip(ExportButt, "Кнопка экспорта базы данных.");
            //Подсказки на остальное (текст боксы и тп.)
            Spravka.SetToolTip(CardNumberNumeric, "Поле для ввода номера карточки пациента в базе.");
            Spravka.SetToolTip(FamiliyaBox, "Поле для ввода фамилии пациента.");
            Spravka.SetToolTip(NameAndOtchestvo, "Поле для ввода имени и отчества.");
            Spravka.SetToolTip(TypeOfWorkBox, "Поле для ввода вида процедуры, которую назначил стоматолог.");
            Spravka.SetToolTip(CostOfWork, "Стоимость выполненной процедуры.");
            Spravka.SetToolTip(PaymentNumerical, "Оплатил ли пациент процедуру. Да, если оплатил. Нет, если не оплатил.");
            Spravka.SetToolTip(SearchNameTextBox, "Поле для поиска пациента по Фамилии.");
            Spravka.SetToolTip(SearchTypeBox, "Поле для поиска пациентов по виду процедуры.");
            Spravka.SetToolTip(PassTextBox, "Поле для получения прав на разрешение редактирования таблицы, для этого введите пароль.");
            Spravka.SetToolTip(Consol, "Консоль данной базы данных, ошибки и успешные действия будут выводиться тут.");
            Spravka.SetToolTip(Tablitca, "База данных о пациентах стоматолога, тут находятся основные сведения про пациентов.");



            Consol.AppendText("Приветствую вас, Пользователь, вы находитесь в информационной базе данных стоматолога, для начала работы введите пароль!\r\n");
        }

        public void Export() //медот экспорта списка, экспортирует в ту же папку, где находится приложение
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(fileStream);

            for (int i = 0; i < BaseCount; i++)
            {
                Base[i].writeToFile(writer);
            }

            writer.Close();
            fileStream.Close();
        }

        private void ExportButt_Click(object sender, EventArgs e) //кнопка экспорта списка
        {
            Export();
        }
    }
}