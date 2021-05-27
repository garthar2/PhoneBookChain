﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;



namespace PhoneBookChain
{
    public partial class PhoneBookForm : Form
    {
        //  https://www.youtube.com/watch?v=6uSWzKMgbzs
        public static string datafile = null; //путь к файлу base.xml
        public static bool unsaved = false;
        public static string config = null;//путь к файлу phonebook.cfg
        //public static System.Collections.ArrayList database = new System.Collections.ArrayList();
        //public static string[] elements = { "name", "phone1", "phone2", "phone3", "mail", "organisation", "departament", "section", "position" };
        public BindingList<PhoneBook> PhoneBookList { get; set; } = new BindingList<PhoneBook>();
        public BindingList<PhoneBookGrid> PhoneBookGridList { get; set; } = new BindingList<PhoneBookGrid>();
        public PhoneBookForm()
        {

            InitializeComponent();
            phoneBookListBindingSource.DataSource = PhoneBookList;
            phoneBookGridListBindingSource.DataSource = PhoneBookGridList;
            phoneBookGridListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            phoneBookGridListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            phoneBookGridListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);

            foreach (DataGridViewHeaderCell header in phoneBookGridListDataGridView.Rows)
            {
                header.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                header.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(BindingList<PhoneBook>));
            //credentialsListBindingSource.DataSource = CredentialsList;
            config = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\phonebook.cfg";
            datafile = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\base.xml";
            if (File.Exists(config))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(config);
                XmlNode node = doc.DocumentElement.SelectSingleNode("/config/basefile");

                if (node != null)
                {
                    datafile = node.InnerText;
                }

                node = doc.DocumentElement.SelectSingleNode("/config/local");
                if (node != null && node.InnerText.ToLower() == "true")
                {
                    //local_version = true;
                    MessageBox.Show("!");
                }
            }
            if (!(File.Exists(datafile)))
            {
                PhoneBookList.Add(new PhoneBook("dfs1452@gmail.com", new Credentials("Филип", "Дачев", "Бедросович", "Мужск.", new DateTime(1967, 12, 12)),
                new Address("Ленина", "10", "5"), new PhoneInfo("3242342", "Мобил.")));
                saveToXmlFile();
                //PhoneBookList.Clear();
                MessageBox.Show("Файл base.xml не найден, создан новый.");
            }
            // десериализация PhoneBookList
            try
            {
                using (FileStream fs = new FileStream("base.xml", FileMode.Open))
                {
                    PhoneBookList = (BindingList<PhoneBook>)formatter.Deserialize(fs);
                    //fs.Close();

                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ошибка чтения" + ex);
                //throw;
            }
            Console.WriteLine("Объект PhoneBookList десериализован");
            foreach (PhoneBook p in PhoneBookList)
            {
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(p.Credentials.YearOfBirth.ToString("yyyyMMdd"));
                int age = (now - dob) / 10000;
                Console.WriteLine($"Имя: {p.Credentials.FirstName} --- Возраст: {age}");

            }
            CopyListToGrid();

        }

        /// <summary>
        /// Метод копирует базовый список в отображаемый DataGridView список
        /// </summary>
        public void CopyListToGrid()
        {
            PhoneBookGridList.Clear();
            foreach (PhoneBook r in PhoneBookList)
            {
                PhoneBookGridList.Add(new PhoneBookGrid(r.Email, r.Credentials.FirstName, r.Credentials.LastName,
                    r.Credentials.MiddleName, r.Credentials.Gender, r.Credentials.YearOfBirth.ToString("yyyy"),
                    r.Address.StreetName + " " + r.Address.BuildNum + "-" + r.Address.FlatNum,
                    r.PhoneInfo.PhoneNum, r.PhoneInfo.IsMobile));
            }

        }
        private void saveToXmlFile()
        {
            // передаем в конструктор тип класса
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<PhoneBook>));
            //FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate);
            TextWriter writer = new StreamWriter("base.xml");
            serializer.Serialize(writer, PhoneBookList);
            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList);
            DialogResult dr = form2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
               CopyListToGrid();
            }
        }

        private void PhoneBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveToXmlFile();
        }

        //private void editButton_Click(object sender, EventArgs e)
        //{
        //    //редактировать
        //    //MessageBox.Show("Выбрано строк:" + phoneBookGridListDataGridView.SelectedRows.Count);
        //    if (this.phoneBookGridListDataGridView.SelectedRows.Count > 0)
        //    {
        //        var rowIndex = phoneBookGridListDataGridView.SelectedRows[0].Index;
        //        AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList, phoneBookGridListDataGridView.SelectedRows[0].Index);

        //        DialogResult dr = form2.ShowDialog();
        //        if (dr == DialogResult.Cancel)
        //        {
        //            CopyListToGrid();
        //        }
        //        //фокус на текущую строку
        //        phoneBookGridListDataGridView.Rows[rowIndex].Selected = true;
        //    }
        //    else
        //    {
        //        var rowIndex = phoneBookGridListDataGridView.CurrentCell.RowIndex;
        //        AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList, phoneBookGridListDataGridView.CurrentCell.RowIndex);
        //        DialogResult dr = form2.ShowDialog();
        //        if (dr == DialogResult.Cancel)
        //        {
        //            CopyListToGrid();
        //        }
        //        //фокус на текущую строку
        //        phoneBookGridListDataGridView.Rows[rowIndex].Selected = true;
        //    }

        //}

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    //удалить строку
        //    if (this.phoneBookGridListDataGridView.SelectedRows.Count > 0)
        //    {
        //        PhoneBookList.RemoveAt(phoneBookGridListDataGridView.SelectedRows[0].Index);
        //        CopyListToGrid();
        //        //MessageBox.Show("Индекс удаленной строки: " + phoneBookGridListDataGridView.SelectedRows[0].Index);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Выберите строку для удаления");
        //    }
        //}

        private void Add_toolStripButton1_Click(object sender, EventArgs e)
        {
            AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList);
            DialogResult dr = form2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                CopyListToGrid();
            }
            phoneBookGridListDataGridView.Rows[phoneBookGridListDataGridView.RowCount - 1].Selected = true;
        }

        private void Edit_toolStripButton2_Click(object sender, EventArgs e)
        {
            //редактировать
            //MessageBox.Show("Выбрано строк:" + phoneBookGridListDataGridView.SelectedRows.Count);
            if (this.phoneBookGridListDataGridView.SelectedRows.Count > 0)
            {
                var rowIndex = phoneBookGridListDataGridView.SelectedRows[0].Index;
                AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList, phoneBookGridListDataGridView.SelectedRows[0].Index);
                DialogResult dr = form2.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    CopyListToGrid();
                }
                phoneBookGridListDataGridView.Rows[rowIndex].Selected = true;
            }
            else
            {
                var rowIndex = phoneBookGridListDataGridView.CurrentCell.RowIndex;
                AddPhoneBookForm form2 = new AddPhoneBookForm(PhoneBookList, phoneBookGridListDataGridView.CurrentCell.RowIndex);
                DialogResult dr = form2.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    CopyListToGrid();
                }
                phoneBookGridListDataGridView.Rows[rowIndex].Selected = true;
            }
        }

        private void Delete_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.phoneBookGridListDataGridView.SelectedRows.Count > 0)
            {
                PhoneBookList.RemoveAt(phoneBookGridListDataGridView.SelectedRows[0].Index);
                CopyListToGrid();
                //MessageBox.Show("Индекс удаленной строки: " + phoneBookGridListDataGridView.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
    }
}
