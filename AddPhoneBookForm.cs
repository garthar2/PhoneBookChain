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
        public int phoneBookIndex = -1;
        public AddPhoneBookForm()
        {
            InitializeComponent();
        }

        public AddPhoneBookForm(BindingList<PhoneBook> phoneBookList)
        {
            PhoneBookList = phoneBookList;
            InitializeComponent();
        }
        public AddPhoneBookForm(BindingList<PhoneBook> phoneBookList, int index)
        {
            int currentIndex = index;
            PhoneBookList = phoneBookList;
            InitializeComponent();
            emailTextBox.Text = PhoneBookList[currentIndex].Email;
            lastNameTextBox.Text = PhoneBookList[currentIndex].Credentials.LastName;
            firstNameTextBox.Text = PhoneBookList[currentIndex].Credentials.FirstName;
            middleNameTextBox.Text = PhoneBookList[currentIndex].Credentials.MiddleName;
            yearOfBirthDateTimePicker.Text = PhoneBookList[currentIndex].Credentials.YearOfBirth.ToString();
            phoneBookIndex = index;
        }

        private void save_button4_Click(object sender, EventArgs e)
        {
            //todo
            //Сохранить всю строку, с email  и объединенными полями с 3х форм
            //PhoneInfoList.Add(new PhoneInfo(firstNameTextBox.Text, emailTextBox.Text));
            //PhoneBookList.Add(new PhoneBook("dfs1452@gmail.com", new Credentials("Филип", "Дачев", "Бедросович", "Мужск.", new DateTime(1967, 12, 12)),
            //    new Address("Ленина", "10", "5"), new PhoneInfo("3242342", "Мобил.")));
            PhoneBook newPhoneBook = new PhoneBook(emailTextBox.Text, new Credentials(firstNameTextBox.Text, lastNameTextBox.Text, middleNameTextBox.Text,
                    genderTextBox.Text, yearOfBirthDateTimePicker.Value), new Address(streetNameTextBox.Text, buildNumTextBox.Text,
                    flatNumTextBox.Text), new PhoneInfo(phoneNumTextBox.Text, isMobileTextBox.Text));
            if (phoneBookIndex==-1)
            {
                PhoneBookList.Add(newPhoneBook);
            }
            else
            {
                PhoneBookList[phoneBookIndex] = newPhoneBook;
            }
            this.Close();

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

        private void AddPhoneBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cancel_button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
