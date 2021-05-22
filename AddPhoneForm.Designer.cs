
namespace PhoneBookChain
{
    partial class AddPhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhoneForm));
            this.phoneInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneInfoListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.Add_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Edit_toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Del_toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.phoneInfoListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingNavigator)).BeginInit();
            this.phoneInfoListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneInfoListBindingSource
            // 
            this.phoneInfoListBindingSource.DataSource = typeof(PhoneBookChain.PhoneInfo);
            // 
            // phoneInfoListBindingNavigator
            // 
            this.phoneInfoListBindingNavigator.AddNewItem = null;
            this.phoneInfoListBindingNavigator.BindingSource = this.phoneInfoListBindingSource;
            this.phoneInfoListBindingNavigator.CountItem = null;
            this.phoneInfoListBindingNavigator.DeleteItem = null;
            this.phoneInfoListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.phoneInfoListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_toolStripButton1,
            this.bindingNavigatorSeparator,
            this.Edit_toolStripButton2,
            this.Del_toolStripButton3});
            this.phoneInfoListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneInfoListBindingNavigator.MoveFirstItem = null;
            this.phoneInfoListBindingNavigator.MoveLastItem = null;
            this.phoneInfoListBindingNavigator.MoveNextItem = null;
            this.phoneInfoListBindingNavigator.MovePreviousItem = null;
            this.phoneInfoListBindingNavigator.Name = "phoneInfoListBindingNavigator";
            this.phoneInfoListBindingNavigator.PositionItem = null;
            this.phoneInfoListBindingNavigator.Size = new System.Drawing.Size(353, 27);
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // Del_toolStripButton3
            // 
            this.Del_toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("Del_toolStripButton3.Image")));
            this.Del_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_toolStripButton3.Name = "Del_toolStripButton3";
            this.Del_toolStripButton3.Size = new System.Drawing.Size(89, 24);
            this.Del_toolStripButton3.Text = "Удалить";
            this.Del_toolStripButton3.Click += new System.EventHandler(this.Del_toolStripButton3_Click);
            // 
            // phoneInfoListDataGridView
            // 
            this.phoneInfoListDataGridView.AllowUserToAddRows = false;
            this.phoneInfoListDataGridView.AllowUserToDeleteRows = false;
            this.phoneInfoListDataGridView.AutoGenerateColumns = false;
            this.phoneInfoListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneInfoListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.phoneInfoListDataGridView.DataSource = this.phoneInfoListBindingSource;
            this.phoneInfoListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneInfoListDataGridView.Location = new System.Drawing.Point(0, 27);
            this.phoneInfoListDataGridView.Name = "phoneInfoListDataGridView";
            this.phoneInfoListDataGridView.ReadOnly = true;
            this.phoneInfoListDataGridView.RowHeadersWidth = 51;
            this.phoneInfoListDataGridView.RowTemplate.Height = 24;
            this.phoneInfoListDataGridView.Size = new System.Drawing.Size(353, 293);
            this.phoneInfoListDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PhoneNum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IsMobile";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип телефона";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // AddPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 320);
            this.Controls.Add(this.phoneInfoListDataGridView);
            this.Controls.Add(this.phoneInfoListBindingNavigator);
            this.Name = "AddPhoneForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление номера телефона";
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingNavigator)).EndInit();
            this.phoneInfoListBindingNavigator.ResumeLayout(false);
            this.phoneInfoListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource phoneInfoListBindingSource;
        private System.Windows.Forms.BindingNavigator phoneInfoListBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton Add_toolStripButton1;
        private System.Windows.Forms.ToolStripButton Edit_toolStripButton2;
        private System.Windows.Forms.ToolStripButton Del_toolStripButton3;
        private System.Windows.Forms.DataGridView phoneInfoListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}