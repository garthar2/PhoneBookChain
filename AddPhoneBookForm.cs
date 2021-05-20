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

            lastNameTextBox.Text = PhoneBookList[index].Credentials.LastName + " " + PhoneBookList[index].Credentials.FirstName
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
            string[] splitCreds = lastNameTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newCreds = new string[] { " ", " ", " " , " " ," "};
            int z = splitCreds.Length > 5 ? 5 : splitCreds.Length;
            for (int i = 0; i < z; i++)
            {
                newCreds[i] = splitCreds[i];
            }
            try
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], new DateTime(Convert.ToInt32(newCreds[4]), 1, 1));

            }
            catch (FormatException)
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], new DateTime(Convert.ToInt32("2001"), 1, 1));
            }
            catch (ArgumentOutOfRangeException)
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], new DateTime(Convert.ToInt32("2000"), 1, 1));
            }
            string[] splitAddress = addressTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newAddress = new string[] { " ", " ", " " };
            z = splitAddress.Length > 3 ? 3 : splitAddress.Length;
            for (int i = 0; i < z; i++)
            {
                newAddress[i] = splitAddress[i];
            }
            newPhoneBook.Address = new Address(newAddress[0], newAddress[1], newAddress[2]);
            string[] splitPhone = phoneNumTextBox.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            string[] newPhone = new string[] { " ", " " };
            z = splitPhone.Length > 2 ? 2 : splitPhone.Length;
            for (int i = 0; i < z; i++)
            {
                newPhone[i] = splitPhone[i];
            }
            newPhoneBook.PhoneInfo = new PhoneInfo (newPhone[0], newPhone[1]);

            newPhoneBook.Email = emailTextBox.Text;
            if (isEditForm)
            {
                //newPhoneBook.Credentials.Gender = PhoneBookList[phoneBookIndex].Credentials.Gender;
                //newPhoneBook.Credentials.Gender = savedGender;
                //newPhoneBook.PhoneInfo.IsMobile = PhoneBookList[phoneBookIndex].PhoneInfo.IsMobile;
                //newPhoneBook.PhoneInfo.IsMobile = savedIsMobile;
                PhoneBookList[phoneBookIndex] = newPhoneBook; //затираются 2 поля "Пол" "Тип телефона"
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
                //вышли из формы, заносим в поле результат
                DialogResult dr = form3.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //this.PhoneBookList[phoneBookIndex].Credentials = form3.resultCredentials;
                    // переделать . Писать не в базу, а в текст бокс. В базу пишет кнопка  Сохранить
                    lastNameTextBox.Text = form3.resultCredentials.LastName + " " + form3.resultCredentials.FirstName
                        + " " + form3.resultCredentials.MiddleName + " " + form3.resultCredentials.Gender + " " + form3.resultCredentials.YearOfBirth.ToString("yyyy");
                }
            }
            else
            {
                AddCredForm form3 = new AddCredForm();
                //вышли из формы, заносим в поле результат
                DialogResult dr = form3.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //this.PhoneBookList.Add(new PhoneBook());
                    //this.PhoneBookList.Add(new PhoneBook("", new Credentials("", "", "", "Мужск.", new DateTime(1967, 12, 12)),new Address("", "", ""), new PhoneInfo("", "Мобил.")));
                    //this.PhoneBookList[PhoneBookList.Count - 1].Credentials = form3.resultCredentials;
                    lastNameTextBox.Text = form3.resultCredentials.LastName + " " + form3.resultCredentials.FirstName
                        + " " + form3.resultCredentials.MiddleName + " " + form3.resultCredentials.Gender + " " + form3.resultCredentials.YearOfBirth.ToString("yyyy");
                }
            }
    
                //заполняем поля формы для редактирования
                //emailTextBox.Text = PhoneBookList[phoneBookIndex].Email;
        }

        private void AdrTripleDot_button2_Click(object sender, EventArgs e)
        {
            AddAddressForm form4 = new AddAddressForm();
            form4.ShowDialog();
            //addressTextBox.Text = PhoneBookList[phoneBookIndex].Address.StreetName + " " +
            //    PhoneBookList[phoneBookIndex].Address.BuildNum + " " + PhoneBookList[phoneBookIndex].Address.FlatNum;
        }

        private void PhoneTripleDot_button3_Click(object sender, EventArgs e)
        {
            AddPhoneForm form5 = new AddPhoneForm();
            form5.ShowDialog();
            //phoneNumTextBox.Text = PhoneBookList[phoneBookIndex].PhoneInfo.PhoneNum;
            //PhoneBookForm.CopyListToGrid();
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
