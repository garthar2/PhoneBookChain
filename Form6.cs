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
    public partial class Form6 : Form
    {
        string gender = "муж";
        public BindingList<Credentials> CredentialsList { get; set; }
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(BindingList<Credentials> credentialsList)
        {
            CredentialsList = credentialsList;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = "Мужск.";
            }
            if (radioButton2.Checked)
            {
                gender = "Женск.";

            }
            CredentialsList.Add(new Credentials(firstNameTextBox.Text, lastNameTextBox.Text,
                middleNameTextBox.Text, gender, yearOfBirthDateTimePicker.Value));
        }
    }
}
