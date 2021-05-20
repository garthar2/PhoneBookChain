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
    public partial class AddRowCredForm : Form
    {
        string gender = ""; //никогда это значение
                            //private BindingList<PhoneBook> PhoneBookList;
        bool isEditedForm = false;
        int currentIndex;

        public BindingList<Credentials> CredentialsList { get; set; }
        public AddRowCredForm()
        {
            isEditedForm = false;
            InitializeComponent();
        }
        public AddRowCredForm(BindingList<Credentials> credentialsList)
        {
            isEditedForm = false;
            CredentialsList = credentialsList;
            InitializeComponent();
        }
        public AddRowCredForm(BindingList<Credentials> credentialsList, int index)
        {
            currentIndex = index;
            isEditedForm = true;
            CredentialsList = credentialsList;
            InitializeComponent();
            this.Text = "Редактирование телефонного справочника (обобщающий класс)";
            //заполняем поля формы для редактирования
            lastNameTextBox.Text = CredentialsList[index].LastName;
            firstNameTextBox.Text = CredentialsList[index].FirstName;
            middleNameTextBox.Text = CredentialsList[index].MiddleName;
            //middleNameTextBox.Text = CredentialsList[currentIndex].MiddleName;
            if (CredentialsList[index].Gender == "Мужск.")
            {
                radioButton1.Checked = true;
            }
            else if (CredentialsList[index].Gender == "Женск.")
            {
                radioButton2.Checked = true;
            }
            yearOfBirthDateTimePicker.Value = CredentialsList[index].YearOfBirth;

        }

        private void saveRow_button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = "Мужск.";
            }
            else if (radioButton2.Checked)
            {
                gender = "Женск.";
            }
            if ((firstNameTextBox.Text == "") || (lastNameTextBox.Text == ""))
            {
                MessageBox.Show("Имя и фамилия не должны быть пустыми!");
            }
            else
            {
                if (isEditedForm)
                {
                    CredentialsList[currentIndex] = new Credentials(firstNameTextBox.Text, lastNameTextBox.Text,
                    middleNameTextBox.Text, gender, yearOfBirthDateTimePicker.Value);
                }
                else
                {
                    CredentialsList.Add(new Credentials(firstNameTextBox.Text, lastNameTextBox.Text,
                    middleNameTextBox.Text, gender, yearOfBirthDateTimePicker.Value));
                }

            }

            this.Close();
        }

        private void cancelRow_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
