﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace PhoneBookChain
{
    public partial class AddPhoneBookForm : Form
    {
        public BindingList<PhoneBook> PhoneBookList { get; set; }
        public int phoneBookIndex;
        bool isEditForm = false;
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
            if (PhoneBookList[index].Credentials.LastName ==" ")
            {
                PhoneBookList[index].Credentials.LastName = "-";
            }
            if (PhoneBookList[index].Credentials.FirstName == " ")
            {
                PhoneBookList[index].Credentials.FirstName = "-";
            }
            if (PhoneBookList[index].Credentials.MiddleName == " ")
            {
                PhoneBookList[index].Credentials.MiddleName = "-";
            }
            if (PhoneBookList[index].Credentials.Gender == " ")
            {
                PhoneBookList[index].Credentials.Gender = "-";
            }

            credenTextBox.Text = PhoneBookList[index].Credentials.LastName + " " + PhoneBookList[index].Credentials.FirstName
                + " " + PhoneBookList[index].Credentials.MiddleName + " " + PhoneBookList[index].Credentials.Gender + " " + 
                PhoneBookList[index].Credentials.YearOfBirth.ToString("dd.MM.yyyy");

            addressTextBox.Text = PhoneBookList[index].Address.StreetName + " " +
                PhoneBookList[index].Address.BuildNum + " " + PhoneBookList[index].Address.FlatNum;

            phoneNumTextBox.Text = PhoneBookList[index].PhoneInfo.PhoneNum + " " + phoneBookList[index].PhoneInfo.IsMobile;

            phoneBookIndex = index;
        }

        private void Save_button4_Click(object sender, EventArgs e)
        {
            PhoneBook newPhoneBook = new PhoneBook();

            if (isEditForm)
            {
                newPhoneBook = PhoneBookList[phoneBookIndex];
            }
            else
            {

            }

            char[] delimiterChars = { ' ', ',', ':', '\t' };
            //char[] delimiterChars = { ' ', ',', ':', '\t','-' };
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
                DateTime.TryParseExact(newCreds[4], "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime parsedDate);
                if (parsedDate < new DateTime(Convert.ToInt32("1900"), 1, 1))
                {
                    parsedDate = new DateTime(Convert.ToInt32("1900"), 1, 1);
                }
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], parsedDate);
            }
            catch (FormatException)
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], 
                    new DateTime(Convert.ToInt32("1"), 1, 1));
            }
            catch (ArgumentOutOfRangeException)
            {
                newPhoneBook.Credentials = new Credentials(newCreds[1], newCreds[0], newCreds[2], newCreds[3], 
                    new DateTime(Convert.ToInt32("0"), 1, 1));
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
                    this.PhoneBookList[phoneBookIndex].Credentials = form3.ResultCred;
                    credenTextBox.Text = form3.ResultCred.LastName + " " + form3.ResultCred.FirstName
                        + " " + form3.ResultCred.MiddleName + " " + form3.ResultCred.Gender + " " + form3.ResultCred.YearOfBirth.ToString("dd.MM.yyyy");
                }
            }
            else
            {
                AddCredForm form3 = new AddCredForm();
                DialogResult dr = form3.ShowDialog();
                //вышли из формы добавления, заносим в текстбокс  результат
                if (dr == DialogResult.Cancel)
                {
                    credenTextBox.Text = form3.ResultCred.LastName + " " + form3.ResultCred.FirstName
                        + " " + form3.ResultCred.MiddleName + " " + form3.ResultCred.Gender + " " + form3.ResultCred.YearOfBirth.ToString("dd.MM.yyyy");
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
                    this.PhoneBookList[phoneBookIndex].Address = form4.ResultAddr;
                    addressTextBox.Text = form4.ResultAddr.StreetName + " " + form4.ResultAddr.BuildNum
                        + " " + form4.ResultAddr.FlatNum;
                }
            }
            else
            {
                AddAddressForm form4 = new AddAddressForm();
                DialogResult dr = form4.ShowDialog();
                //вышли из формы добавления, заносим в текстбокс  результат
                if (dr == DialogResult.Cancel)
                {
                    addressTextBox.Text = form4.ResultAddr.StreetName + " " + form4.ResultAddr.BuildNum
                        + " " + form4.ResultAddr.FlatNum;
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
