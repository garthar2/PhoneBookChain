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
    public partial class AddRowPhoneForm : Form
    {
        bool isEditedForm = false;
        int currentIndex;
        public BindingList<PhoneInfo> PhoneInfoList { get; set; }
        public AddRowPhoneForm()
        {
            isEditedForm = false;
            InitializeComponent();
        }
        public AddRowPhoneForm(BindingList<PhoneInfo> phoneInfoList)
        {
            isEditedForm = false;
            PhoneInfoList = phoneInfoList;
            InitializeComponent();
        }
        public AddRowPhoneForm(BindingList<PhoneInfo> phoneInfoList, int index)
        {
            isEditedForm = true;
            PhoneInfoList = phoneInfoList;
            currentIndex = index;
            InitializeComponent();
            this.Text = "Редактирование номера телефона";
            //заполняем поля формы для редактирования
            phoneNumTextBox.Text = PhoneInfoList[index].PhoneNum;
            if (PhoneInfoList[index].IsMobile == "Моб.")
            {
                mob_radioButton1.Checked = true;
            }
            else
            {
                home_radioButton2.Checked = true;
            }
        }

        private void savePhoneInfo_button_Click(object sender, EventArgs e)
        {
            var isMobile = "Моб.";
            if (mob_radioButton1.Checked)
            {
                isMobile = "Моб.";
            }
            else if (home_radioButton2.Checked)
            {
                isMobile = "Дом.";
            }
            if (isEditedForm)
            {
                PhoneInfoList[currentIndex] = new PhoneInfo(phoneNumTextBox.Text, isMobile);
            }
            else
            {
                PhoneInfoList.Add(new PhoneInfo(phoneNumTextBox.Text, isMobile));
            }
            this.Close();
        }

        private void Cancel_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
