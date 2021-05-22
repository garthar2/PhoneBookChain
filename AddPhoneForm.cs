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
    public partial class AddPhoneForm : Form
    {
        public BindingList<PhoneInfo> PhoneInfoList { get; set; } = new BindingList<PhoneInfo>();

        private PhoneInfo PhoneInfo;
        public PhoneInfo resultPhoneInfo
        {
            get
            {
                //проверка, выбрана строка или ячейка
                if (this.phoneInfoListDataGridView.SelectedRows.Count > 0)
                {
                    return PhoneInfoList[phoneInfoListDataGridView.SelectedRows[0].Index];
                }
                else
                {
                    return PhoneInfoList[phoneInfoListDataGridView.CurrentCell.RowIndex];
                }
            }
        }
        public AddPhoneForm()
        {
            InitializeComponent();
            phoneInfoListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            phoneInfoListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            phoneInfoListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        }
        public AddPhoneForm(PhoneInfo phoneInfo, int RowIndex)
        {
            PhoneInfo = phoneInfo;
            int rowIndex = RowIndex;
            InitializeComponent();
            PhoneInfoList.Add(new PhoneInfo());
            PhoneInfoList[0] = PhoneInfo;
            phoneInfoListDataGridView.DataSource = PhoneInfoList;
            phoneInfoListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            phoneInfoListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            phoneInfoListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.Text = "Редактирование списка телефонов";
        }

        private void Add_toolStripButton1_Click(object sender, EventArgs e)
        {
            AddRowPhoneForm CreatePhoneInfo = new AddRowPhoneForm(PhoneInfoList);
            CreatePhoneInfo.ShowDialog();
        }

        private void Edit_toolStripButton2_Click(object sender, EventArgs e)
        {
            //редактировать
            //MessageBox.Show("Выбрано строк:" + addressListDataGridView.SelectedRows.Count);

            if (this.phoneInfoListDataGridView.SelectedRows.Count > 0)
            {
                AddRowPhoneForm CreatePhoneInfo = new AddRowPhoneForm(PhoneInfoList, phoneInfoListDataGridView.SelectedRows[0].Index);

                DialogResult dr = CreatePhoneInfo.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //CopyListToGrid();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.");
            }
            //else if (phoneInfoListDataGridView.CurrentCell.RowIndex >= 0)
            //{
            //    AddRowPhoneForm CreatePhoneInfo = new AddRowPhoneForm(PhoneInfoList, phoneInfoListDataGridView.CurrentCell.RowIndex);
            //    DialogResult dr = CreatePhoneInfo.ShowDialog();
            //    if (dr == DialogResult.Cancel)
            //    {
            //        //CopyListToGrid();
            //    }
            //}

        }

        private void Del_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.phoneInfoListDataGridView.SelectedRows.Count > 0)
            {
                //MessageBox.Show("Индекс строки: " + credentialsListDataGridView.SelectedRows[0].Index);
                PhoneInfoList.RemoveAt(phoneInfoListDataGridView.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }
    }
}
