using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneBookChain
{
    public partial class Form2 : Form
    {
        public BindingList<PhoneBook> PhoneBookList { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(BindingList<PhoneBook> phoneBookList)
        {
            PhoneBookList = phoneBookList;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //todo
            //Сохранить всю строку, с email  и объединенными полями с 3х форм
            //PhoneInfoList.Add(new PhoneInfo(firstNameTextBox.Text, emailTextBox.Text));





            PhoneBookList.Add(new PhoneBook(firstNameTextBox.Text, lastNameTextBox.Text, middleNameTextBox.Text,
                genderCheckBox.Checked, yearOfBirthDateTimePicker.Value, streetNameTextBox.Text, buildNumTextBox.Text,
                flatNumTextBox.Text, phoneNumTextBox.Text, isMobileCheckBox.Checked, emailTextBox.Text));




            //PhoneInfoList.Add(new PhoneInfo("Васян", "Дачев", "Бедросович", false, new DateTime(1967, 12, 12),
            //   "Ленина", "10", "5", "3242342", false, "asd@sdfs.com"));
            //PhoneInfoList.Add(new PhoneInfo(Name, Name, Name, false, new DateTime(1967, 12, 12),
            //    Name, Name, Name, Name, false, Name));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
