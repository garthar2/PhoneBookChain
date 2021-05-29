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
    public partial class AddRowAddressForm : Form
    {
        bool isEditedForm = false;
        int currentIndex;
        public BindingList<Address> AddressList { get; set; }

        public AddRowAddressForm()
        {
            isEditedForm = false;
            InitializeComponent();
        }
        public AddRowAddressForm(BindingList<Address> addressList)
        {
            isEditedForm = false;
            AddressList = addressList;
            InitializeComponent();
        }
        public AddRowAddressForm(BindingList<Address> addressList,int index)
        {
            isEditedForm = true;
            AddressList = addressList;
            currentIndex = index;
            InitializeComponent();
            this.Text = "Редактирование адреса";
            //заполняем поля формы для редактирования
            streetNameTextBox.Text = AddressList[index].StreetName;
            buildNumTextBox.Text = AddressList[index].BuildNum;
            flatNumTextBox.Text = AddressList[index].FlatNum;
        }

        private void SaveAddAdrbutton_Click(object sender, EventArgs e)
        {
            //if ((streetName == "") || (lastNameTextBox.Text == ""))
            //{
            //    MessageBox.Show("Имя и фамилия не должны быть пустыми!");
            //}
            //else
            //{
            //    AddressList.Add(new Address(streetNameTextBox.Text));
            //}
            streetNameTextBox.Text = streetNameTextBox.Text == "" ? "-" : streetNameTextBox.Text;
            buildNumTextBox.Text = buildNumTextBox.Text == "" ? "-" : buildNumTextBox.Text;
            flatNumTextBox.Text = flatNumTextBox.Text == "" ? "-" : flatNumTextBox.Text;
            if (isEditedForm)
            {
                AddressList[currentIndex] = new Address(streetNameTextBox.Text, buildNumTextBox.Text,
                flatNumTextBox.Text);
            }
            else
            {
                AddressList.Add(new Address(streetNameTextBox.Text, buildNumTextBox.Text,
                flatNumTextBox.Text));
            }

            this.Close();
        }

        private void CancelAddAdrbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
