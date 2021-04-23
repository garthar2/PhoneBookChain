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
    public partial class AddPhoneBookForm : Form
    {
        public BindingList<PhoneBook> PhoneBookList { get; set; }
        public AddPhoneBookForm()
        {
            InitializeComponent();
        }

        public AddPhoneBookForm(BindingList<PhoneBook> phoneBookList)
        {
            PhoneBookList = phoneBookList;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //todo
            //Сохранить всю строку, с email  и объединенными полями с 3х форм
            //PhoneInfoList.Add(new PhoneInfo(firstNameTextBox.Text, emailTextBox.Text));
            PhoneBookList.Add(new PhoneBook("Васян", "Дачев", "Бедросович", false, new DateTime(1967, 12, 12),
                                             "Ленина", "10", "5", "3242342", false, "asd@sdfs.com"));




            PhoneBookList.Add(new PhoneBook(firstNameTextBox.Text, lastNameTextBox.Text, middleNameTextBox.Text,
                genderCheckBox.Checked, yearOfBirthDateTimePicker.Value, streetNameTextBox.Text, buildNumTextBox.Text,
                flatNumTextBox.Text, phoneNumTextBox.Text, isMobileCheckBox.Checked, emailTextBox.Text));






        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCredForm form3 = new AddCredForm();
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAddressForm form4 = new AddAddressForm();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPhoneForm form5 = new AddPhoneForm();
            form5.ShowDialog();
        }
    }
}
