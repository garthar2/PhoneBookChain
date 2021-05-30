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

        private int rowIndex = 0;
        private PhoneInfo PhoneInfo;
        public PhoneInfo ResultPhoneInfo
        {
            get
            {
                //проверка, выбрана строка или ячейка
                //if (this.phoneInfoListDataGridView.SelectedRows.Count > 0)
                //{
                //    return PhoneInfoList[phoneInfoListDataGridView.SelectedRows[0].Index];
                //}
                //else
                //{
                //    return PhoneInfoList[phoneInfoListDataGridView.CurrentCell.RowIndex];
                //}

                if (this.phoneInfoListDataGridView.CurrentCell != null)
                {
                    return PhoneInfoList[phoneInfoListDataGridView.CurrentCell.RowIndex];
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
            PhoneInfoList.Add(new PhoneInfo());
            phoneInfoListDataGridView.DataSource = PhoneInfoList;
            phoneInfoListDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            phoneInfoListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            phoneInfoListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Pixel);

        }
        public AddPhoneForm(PhoneInfo phoneInfo, int RowIndex)
        {
            PhoneInfo = phoneInfo;
            rowIndex = RowIndex;
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

            //if (this.phoneInfoListDataGridView.SelectedRows.Count > 0)
            //{
            //    AddRowPhoneForm CreatePhoneInfo = new AddRowPhoneForm(PhoneInfoList, phoneInfoListDataGridView.SelectedRows[0].Index);

            //    DialogResult dr = CreatePhoneInfo.ShowDialog();
            //    if (dr == DialogResult.Cancel)
            //    {
            //        //CopyListToGrid();
            //    }
            //}
            if (phoneInfoListDataGridView.CurrentCell != null) 
            {
                AddRowPhoneForm CreatePhoneInfo = new AddRowPhoneForm(PhoneInfoList, phoneInfoListDataGridView.CurrentCell.RowIndex);
                CreatePhoneInfo.ShowDialog();
            }

        }

        private void Del_toolStripButton3_Click(object sender, EventArgs e)
        {
            //удалить строку
            if (this.phoneInfoListDataGridView.SelectedRows.Count > 0)
            { 
                if (this.phoneInfoListDataGridView.Rows.Count != 1)
                {
                    PhoneInfoList.RemoveAt(phoneInfoListDataGridView.SelectedRows[0].Index);
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

        private void PhoneInfoListDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex>=0)
                {
                    this.phoneInfoListDataGridView.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.phoneInfoListDataGridView.CurrentCell = this.phoneInfoListDataGridView.Rows[e.RowIndex].Cells[1];
                    this.contextMenuStrip1.Show(this.phoneInfoListDataGridView, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void AddPhoneForm_Load(object sender, EventArgs e)
        {
            this.phoneInfoListDataGridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.phoneInfoListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!this.phoneInfoListDataGridView.Rows[this.rowIndex].IsNewRow)
            //{
            //    this.phoneInfoListDataGridView.Rows.RemoveAt(this.rowIndex);
            //}
            if (this.phoneInfoListDataGridView.Rows.Count != 1)
            {
                this.phoneInfoListDataGridView.Rows.RemoveAt(this.rowIndex);
            }
        }
    }
}
