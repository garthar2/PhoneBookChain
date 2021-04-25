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
        public BindingList<Credentials> CredentialsList { get; set; } = new BindingList<Credentials>();
        public AddCredForm()
        {
            
            InitializeComponent();
            credentialsListBindingSource.DataSource = CredentialsList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //добавить
            AddRowCredForm CreateCredentials = new AddRowCredForm(CredentialsList);
            CreateCredentials.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //редактировать
            MessageBox.Show("Выбрано строк:"+ credentialsListDataGridView.SelectedRows.Count);
            //DataGridView1
            //    credentialsListDataGridView.
        }

        private void button3_Click(object sender, EventArgs e)
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


            //if (this.credentialsListDataGridView.SelectedRows.Count > 0 &&
            //    this.credentialsListDataGridView.SelectedRows[0].Index !=
            //    this.credentialsListDataGridView.Rows.Count - 1)
            //{
            //    this.credentialsListDataGridView.Rows.RemoveAt(
            //        this.credentialsListDataGridView.SelectedRows[0].Index);
            //}

            //this.credentialsListDataGridView.Rows.RemoveAt(
            //    this.credentialsListDataGridView.SelectedRows[0].Index);

        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.CurrentCell.Value = textBox1.Text;
        //}
    }
}
