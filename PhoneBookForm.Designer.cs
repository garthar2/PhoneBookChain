
namespace PhoneBookChain
{
    partial class PhoneBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBookForm));
            this.phoneInfoListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.Add_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Edit_toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Delete_toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBookGridListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBookGridListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneBookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingNavigator)).BeginInit();
            this.phoneInfoListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneInfoListBindingNavigator
            // 
            this.phoneInfoListBindingNavigator.AddNewItem = null;
            this.phoneInfoListBindingNavigator.CountItem = null;
            this.phoneInfoListBindingNavigator.DeleteItem = null;
            this.phoneInfoListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.phoneInfoListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_toolStripButton1,
            this.Edit_toolStripButton2,
            this.Delete_toolStripButton3});
            this.phoneInfoListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneInfoListBindingNavigator.MoveFirstItem = null;
            this.phoneInfoListBindingNavigator.MoveLastItem = null;
            this.phoneInfoListBindingNavigator.MoveNextItem = null;
            this.phoneInfoListBindingNavigator.MovePreviousItem = null;
            this.phoneInfoListBindingNavigator.Name = "phoneInfoListBindingNavigator";
            this.phoneInfoListBindingNavigator.PositionItem = null;
            this.phoneInfoListBindingNavigator.Size = new System.Drawing.Size(1100, 27);
            this.phoneInfoListBindingNavigator.TabIndex = 0;
            this.phoneInfoListBindingNavigator.Text = "bindingNavigator1";
            // 
            // Add_toolStripButton1
            // 
            this.Add_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("Add_toolStripButton1.Image")));
            this.Add_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_toolStripButton1.Name = "Add_toolStripButton1";
            this.Add_toolStripButton1.Size = new System.Drawing.Size(100, 24);
            this.Add_toolStripButton1.Text = "Добавить";
            this.Add_toolStripButton1.Click += new System.EventHandler(this.Add_toolStripButton1_Click);
            // 
            // Edit_toolStripButton2
            // 
            this.Edit_toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("Edit_toolStripButton2.Image")));
            this.Edit_toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_toolStripButton2.Name = "Edit_toolStripButton2";
            this.Edit_toolStripButton2.Size = new System.Drawing.Size(135, 24);
            this.Edit_toolStripButton2.Text = "Редактировать";
            this.Edit_toolStripButton2.Click += new System.EventHandler(this.Edit_toolStripButton2_Click);
            // 
            // Delete_toolStripButton3
            // 
            this.Delete_toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("Delete_toolStripButton3.Image")));
            this.Delete_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_toolStripButton3.Name = "Delete_toolStripButton3";
            this.Delete_toolStripButton3.Size = new System.Drawing.Size(89, 24);
            this.Delete_toolStripButton3.Text = "Удалить";
            this.Delete_toolStripButton3.Click += new System.EventHandler(this.Delete_toolStripButton3_Click);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PhoneInfo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn14.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PhoneInfo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PhoneInfo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // phoneBookGridListDataGridView
            // 
            this.phoneBookGridListDataGridView.AllowUserToAddRows = false;
            this.phoneBookGridListDataGridView.AllowUserToDeleteRows = false;
            this.phoneBookGridListDataGridView.AutoGenerateColumns = false;
            this.phoneBookGridListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneBookGridListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn16});
            this.phoneBookGridListDataGridView.DataSource = this.phoneBookGridListBindingSource;
            this.phoneBookGridListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneBookGridListDataGridView.Location = new System.Drawing.Point(0, 27);
            this.phoneBookGridListDataGridView.Name = "phoneBookGridListDataGridView";
            this.phoneBookGridListDataGridView.ReadOnly = true;
            this.phoneBookGridListDataGridView.RowHeadersWidth = 51;
            this.phoneBookGridListDataGridView.RowTemplate.Height = 24;
            this.phoneBookGridListDataGridView.Size = new System.Drawing.Size(1100, 560);
            this.phoneBookGridListDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn17.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn18.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "MiddleName";
            this.dataGridViewTextBoxColumn19.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn20.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 60;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "YearOfBirth";
            this.dataGridViewTextBoxColumn21.HeaderText = "Год рождения";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 80;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn25.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 200;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "PhoneNum";
            this.dataGridViewTextBoxColumn26.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IsMobile";
            this.dataGridViewTextBoxColumn27.HeaderText = "Тип телефона";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn16.HeaderText = "email";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // phoneBookGridListBindingSource
            // 
            this.phoneBookGridListBindingSource.DataSource = typeof(PhoneBookChain.PhoneBookGrid);
            // 
            // phoneBookListBindingSource
            // 
            this.phoneBookListBindingSource.DataSource = typeof(PhoneBookChain.PhoneBook);
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 587);
            this.Controls.Add(this.phoneBookGridListDataGridView);
            this.Controls.Add(this.phoneInfoListBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефонный справочник (обобщающий класс)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhoneBookForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingNavigator)).EndInit();
            this.phoneInfoListBindingNavigator.ResumeLayout(false);
            this.phoneInfoListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookGridListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator phoneInfoListBindingNavigator;
        private System.Windows.Forms.BindingSource phoneBookListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource phoneBookGridListBindingSource;
        private System.Windows.Forms.ToolStripButton Add_toolStripButton1;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton2;
        private System.Windows.Forms.ToolStripButton Delete_toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridView phoneBookGridListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}

