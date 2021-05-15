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
    public partial class AddCredForm : Form
    {
        //private BindingList<PhoneBook> PhoneBookList;
        private Credentials Credentials;

        public BindingList<Credentials> CredentialsList { get; set; } = new BindingList<Credentials>();
        public AddCredForm()
        {
            
            InitializeComponent();
            credentialsListBindingSource.DataSource = CredentialsList;
        }
        public AddCredForm(Credentials credentials, int RowIndex)
        {
            Credentials = credentials;
            int rowIndex = RowIndex;
            InitializeComponent();
            CredentialsList.Add(new Credentials());
            CredentialsList[0] = Credentials;
            credentialsListBindingSource.DataSource = CredentialsList;
            //credentialsListBindingSource.DataSource = Credentials;
            

        }

         private void Add_toolStripButton1_Click(object sender, EventArgs e)
        {
            //добавить
            AddRowCredForm CreateCredentials = new AddRowCredForm(CredentialsList);
            CreateCredentials.ShowDialog();
        }

        private void Edit_toolStripButton2_Click(object sender, EventArgs e)
        {
            //редактировать
            MessageBox.Show("Выбрано строк:" + credentialsListDataGridView.SelectedRows.Count);
            //вызвать форму AddPhoneForm() с параметрами для "редактирования", всего 4е ФИО, адрес,номер телефона,email
        }

        private void Delete_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.credentialsListDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Индекс строки: " + credentialsListDataGridView.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.CurrentCell.Value = textBox1.Text;
        //}
    }
}
