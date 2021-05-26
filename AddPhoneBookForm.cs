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
        bool isEditForm = false;
        //string savedGender;
        //string savedIsMobile;
        public AddPhoneBookForm()
        {
            InitializeComponent();

        }

        public AddPhoneBookForm(BindingList<PhoneBook> phoneBookList)
        {
            isEditForm = false;
            PhoneBookList = phoneBookList;
            InitializeComponent();

        }
        public AddPhoneBookForm(BindingList<PhoneBook> phoneBookList, int index)
        {
            isEditForm = true;
            //int currentIndex = index; //дублируется c phoneBookIndex -> убрать?
            PhoneBookList = phoneBookList;
            InitializeComponent();
            this.Text = "Редактирование телефонного справочника (обобщающий класс)";
            //заполняем поля формы для редактирования
            emailTextBox.Text = PhoneBookList[index].Email;


            //lastNameTextBox.Text = PhoneBookList[index].Credentials.LastName + " " + 
            //    PhoneBookList[index].Credentials.FirstName + " " + PhoneBookList[index].Credentials.MiddleName;

            credenTextBox.Text = PhoneBookList[index].Credentials.LastName + " " + PhoneBookList[index].Credentials.FirstName
                + " " + PhoneBookList[index].Credentials.MiddleName + " " + PhoneBookList[index].Credentials.Gender + " " + PhoneBookList[index].Credentials.YearOfBirth.ToString("yyyy");

            addressTextBox.Text = PhoneBookList[index].Address.StreetName + " " +
                PhoneBookList[index].Address.BuildNum + " " + PhoneBookList[index].Address.FlatNum;
            phoneNumTextBox.Text = PhoneBookList[index].PhoneInfo.PhoneNum;



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

            if (isEditForm)
            {
                //savedGender = PhoneBookList[phoneBookIndex].Credentials.Gender;
                //savedIsMobile = PhoneBookList[phoneBookIndex].PhoneInfo.IsMobile;
                newPhoneBook = PhoneBookList[phoneBookIndex];
            }
            else
            {

            }

            char[] delimiterChars = { ' ', ',', ':', '\t','-' };
            string[] splitCreds = credenTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newCreds = new string[] { " ", " ", " " , " " ," "};
            int z = splitCreds.Length > 5 ? 5 : splitCreds.Length;
            for (int i = 0; i < z; i++)
            {
                newCreds[i] = splitCreds[i];
                char[] b = newCreds[i].ToCharArray();
                b[0] = Char.ToUpper(b[0]);
                newCreds[i] = new string(b);
            }
            try
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], new DateTime(Convert.ToInt32(newCreds[4]), 1, 1));

            }
            catch (FormatException)
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], new DateTime(Convert.ToInt32("1"), 1, 1));
            }
            catch (ArgumentOutOfRangeException)
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], new DateTime(Convert.ToInt32("0"), 1, 1));
            }
            string[] splitAddress = addressTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newAddress = new string[] { " ", " ", " " };
            z = splitAddress.Length > 3 ? 3 : splitAddress.Length;
            for (int i = 0; i < z; i++)
            {
                newAddress[i] = splitAddress[i];
                char[] b = newAddress[i].ToCharArray();
                b[0] = Char.ToUpper(b[0]);
                newAddress[i] = new string(b);
            }
            newPhoneBook.Address = new Address(newAddress[0], newAddress[1], newAddress[2]);
            string[] splitPhone = phoneNumTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newPhone = new string[] { " ", " " };
            z = splitPhone.Length > 2 ? 2 : splitPhone.Length;
            for (int i = 0; i < z; i++)
            {   
                newPhone[i] = splitPhone[i];
                char[] b = newPhone[i].ToCharArray();
                b[0] = Char.ToUpper(b[0]);
                newPhone[i] = new string(b);
            }
            newPhoneBook.PhoneInfo = new PhoneInfo (newPhone[0], newPhone[1]);

            newPhoneBook.Email = emailTextBox.Text;
            if (isEditForm)
            {
                PhoneBookList[phoneBookIndex] = newPhoneBook;
            }
            else
            {
                PhoneBookList.Add(newPhoneBook);
            }
            this.Close();

        }

        private void CredTripleDot_button1_Click(object sender, EventArgs e)
        {

            if (isEditForm)
            {
                AddCredForm form3 = new AddCredForm(PhoneBookList[phoneBookIndex].Credentials, phoneBookIndex);
                DialogResult dr = form3.ShowDialog();
                //вышли из формы редактирования, заносим в текстбокс и в базу  результат
                if (dr == DialogResult.Cancel)
                {
                    this.PhoneBookList[phoneBookIndex].Credentials = form3.ResultCredentials;
                    credenTextBox.Text = form3.ResultCredentials.LastName + " " + form3.ResultCredentials.FirstName
                        + " " + form3.ResultCredentials.MiddleName + " " + form3.ResultCredentials.Gender + " " + form3.ResultCredentials.YearOfBirth.ToString("yyyy");
                }
            }
            else
            {
                AddCredForm form3 = new AddCredForm();
                DialogResult dr = form3.ShowDialog();
                //вышли из формы добавления, заносим в текстбокс  результат
                if (dr == DialogResult.Cancel)
                {
                    credenTextBox.Text = form3.ResultCredentials.LastName + " " + form3.ResultCredentials.FirstName
                        + " " + form3.ResultCredentials.MiddleName + " " + form3.ResultCredentials.Gender + " " + form3.ResultCredentials.YearOfBirth.ToString("yyyy");
                }
            }
        }

        private void AdrTripleDot_button2_Click(object sender, EventArgs e)
        {
            if (isEditForm)
            {
                //AddAddressForm form4 = new AddAddressForm(PhoneBookList[phoneBookIndex].Address, phoneBookIndex);
                AddAddressForm form4 = new AddAddressForm(PhoneBookList[phoneBookIndex].Address);
                DialogResult dr = form4.ShowDialog();
                //вышли из формы редактирования, заносим в текстбокс и в базу  результат
                if (dr == DialogResult.Cancel)
                {
                    this.PhoneBookList[phoneBookIndex].Address = form4.ResultAddresss;
                    addressTextBox.Text = form4.ResultAddresss.StreetName + " " + form4.ResultAddresss.BuildNum
                        + " " + form4.ResultAddresss.FlatNum;
                }
            }
            else
            {
                AddAddressForm form4 = new AddAddressForm();
                DialogResult dr = form4.ShowDialog();
                //вышли из формы добавления, заносим в текстбокс  результат
                if (dr == DialogResult.Cancel)
                {
                    addressTextBox.Text = form4.ResultAddresss.StreetName + " " + form4.ResultAddresss.BuildNum
                        + " " + form4.ResultAddresss.FlatNum;
                }
            }
        }

        private void PhoneTripleDot_button3_Click(object sender, EventArgs e)
        {
            if (isEditForm)
            {
                AddPhoneForm form5 = new AddPhoneForm(PhoneBookList[phoneBookIndex].PhoneInfo, phoneBookIndex);
                DialogResult dr = form5.ShowDialog();
                //вышли из формы редактирования, заносим в текстбокс и в базу  результат
                if (dr == DialogResult.Cancel)
                {
                    this.PhoneBookList[phoneBookIndex].PhoneInfo = form5.ResultPhoneInfo;
                    phoneNumTextBox.Text = form5.ResultPhoneInfo.PhoneNum + " " + form5.ResultPhoneInfo.IsMobile;
                }
            }
            else
            {
                AddPhoneForm form5 = new AddPhoneForm();
                DialogResult dr = form5.ShowDialog();
                //вышли из формы добавления, заносим в текстбокс  результат
                if (dr == DialogResult.Cancel)
                {
                    //this.PhoneBookList[phoneBookIndex].PhoneInfo = form5.resultPhoneInfo;
                    phoneNumTextBox.Text = form5.ResultPhoneInfo.PhoneNum + " " + form5.ResultPhoneInfo.IsMobile;
                }
            }
        }

        private void AddPhoneBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Cancel_button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XCred_button_Click(object sender, EventArgs e)
        {
            credenTextBox.Text = " ";
        }

        private void XAddr_button_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = " ";
        }

        private void XPhone_button_Click(object sender, EventArgs e)
        {
            phoneNumTextBox.Text = " ";
        }
    }
}
