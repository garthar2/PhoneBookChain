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
            this.Text = "Редактирование телефонного справочника (обобщающий класс)";
            //заполняем поля формы для редактирования
            emailTextBox.Text = PhoneBookList[currentIndex].Email;
            lastNameTextBox.Text = PhoneBookList[currentIndex].Credentials.LastName + " " + 
                PhoneBookList[currentIndex].Credentials.FirstName + " " + PhoneBookList[currentIndex].Credentials.MiddleName;
            addressTextBox.Text = PhoneBookList[currentIndex].Address.StreetName + " " +
                PhoneBookList[currentIndex].Address.BuildNum + " " + PhoneBookList[currentIndex].Address.FlatNum;
            phoneNumTextBox.Text = PhoneBookList[currentIndex].PhoneInfo.PhoneNum;
            phoneBookIndex = index;
        }

        private void save_button4_Click(object sender, EventArgs e)
        {
            //PhoneBook newPhoneBook = new PhoneBook(emailTextBox.Text, new Credentials(PhoneBookList[phoneBookIndex].Credentials.FirstName,
            //    PhoneBookList[phoneBookIndex].Credentials.LastName, PhoneBookList[phoneBookIndex].Credentials.MiddleName,
            //    PhoneBookList[phoneBookIndex].Credentials.Gender, PhoneBookList[phoneBookIndex].Credentials.YearOfBirth),
            //    new Address(PhoneBookList[phoneBookIndex].Address.StreetName, PhoneBookList[phoneBookIndex].Address.BuildNum,
            //    PhoneBookList[phoneBookIndex].Address.FlatNum), new PhoneInfo(PhoneBookList[phoneBookIndex].PhoneInfo.PhoneNum,
            //    PhoneBookList[phoneBookIndex].PhoneInfo.IsMobile));
            PhoneBook newPhoneBook = new PhoneBook();
            string savedGender = PhoneBookList[phoneBookIndex].Credentials.Gender;
            string savedIsMobile = PhoneBookList[phoneBookIndex].PhoneInfo.IsMobile;
            if (phoneBookIndex>=0)
            {
                newPhoneBook = PhoneBookList[phoneBookIndex];
            }

            char[] delimiterChars = { ' ', ',', ':', '\t','-' };
            string[] splitAddress = addressTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newAddress = new string[] { " ", " ", " " };
            int z = splitAddress.Length > 3 ? 3 : splitAddress.Length;
            for (int i = 0; i < z; i++)
            {
                newAddress[i] = splitAddress[i];
            }
            newPhoneBook.Address = new Address (newAddress[0], newAddress[1], newAddress[2]);

            string[] splitCreds = lastNameTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newCreds = new string[] { " ", " ", " " , " " };
            z = splitCreds.Length > 4 ? 4 : splitCreds.Length;
            for (int i = 0; i < z; i++)
            {
                newCreds[i] = splitCreds[i];
            }
            newPhoneBook.Credentials = new Credentials(newCreds[0], newCreds[1], newCreds[2], newCreds[3], DateTime.Now);
            //newPhoneBook.Credentials.FirstName = newCreds[0];
            //newPhoneBook.Credentials.LastName = newCreds[1];
            //newPhoneBook.Credentials.MiddleName = newCreds[2];
            //newPhoneBook.Credentials.Gender = newCreds[3];

            string[] splitPhone = phoneNumTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newPhone = new string[] { " ", " " };
            z = splitPhone.Length > 2 ? 2 : splitPhone.Length;
            for (int i = 0; i < z; i++)
            {
                newPhone[i] = splitPhone[i];
            }
            newPhoneBook.PhoneInfo = new PhoneInfo (newPhone[0], newPhone[1]);

            newPhoneBook.Email = emailTextBox.Text;
            if (phoneBookIndex==-1)
            {
                PhoneBookList.Add(newPhoneBook);
            }
            else
            {
                //newPhoneBook.Credentials.Gender = PhoneBookList[phoneBookIndex].Credentials.Gender;
                newPhoneBook.Credentials.Gender = savedGender;
                //newPhoneBook.PhoneInfo.IsMobile = PhoneBookList[phoneBookIndex].PhoneInfo.IsMobile;
                newPhoneBook.PhoneInfo.IsMobile = savedIsMobile;
                PhoneBookList[phoneBookIndex] = newPhoneBook; //затираются 2 поля "Пол" "Тип телефона"
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddCredForm form3 = new AddCredForm();
            //form3.ShowDialog();


            AddCredForm form3 = new AddCredForm(PhoneBookList[phoneBookIndex].Credentials, phoneBookIndex);
            DialogResult dr = form3.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                //PhoneBookForm.CopyToGrid();
            }
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
