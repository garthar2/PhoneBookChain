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
        private readonly Credentials Credentials;
        public Credentials ResultCred
        {
            get
            {
                //проверка, выбрана строка или ячейка
                if (this.credentialsListDataGridView.SelectedRows.Count > 0)
                {
                    return CredentialsList[credentialsListDataGridView.SelectedRows[0].Index];
                }
                else
                {
                    return CredentialsList[credentialsListDataGridView.CurrentCell.RowIndex];
                }
            }
        }

        public BindingList<Credentials> CredentialsList { get; set; } = new BindingList<Credentials>();
        public AddCredForm()
        {
            InitializeComponent();
            CredentialsList.Add(new Credentials());
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
            credentialsListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            credentialsListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            credentialsListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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

            if (this.credentialsListDataGridView.CurrentCell != null)
            {
                AddRowCredForm EditCredentials = new AddRowCredForm(CredentialsList, credentialsListDataGridView.CurrentCell.RowIndex);
                DialogResult dr = EditCredentials.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                }
            }
            //else
            //{
            //    MessageBox.Show("Выберите строку для редактирования.");
            //    //AddRowCredForm CreateCredentials = new AddRowCredForm(CredentialsList, credentialsListDataGridView.CurrentCell.RowIndex);
            //    //DialogResult dr = CreateCredentials.ShowDialog();
            //    //if (dr == DialogResult.Cancel)
            //    //{
            //    //}
            //}
        }

        private void Delete_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.credentialsListDataGridView.SelectedRows.Count > 0)
            {
                if (this.credentialsListDataGridView.Rows.Count != 1)
                {
                    CredentialsList.RemoveAt(credentialsListDataGridView.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Всегда должна быть хоть одна строка...");
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }

        }
        private void AddCredForm_Load(object sender, EventArgs e)
        {
            this.credentialsListDataGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.credentialsListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }
    }
}
