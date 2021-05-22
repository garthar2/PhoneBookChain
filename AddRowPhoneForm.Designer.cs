
namespace PhoneBookChain
{
    partial class AddRowPhoneForm
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
            System.Windows.Forms.Label isMobileLabel;
            System.Windows.Forms.Label phoneNumLabel;
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.savePhoneInfo_button = new System.Windows.Forms.Button();
            this.Cancel_button1 = new System.Windows.Forms.Button();
            this.phoneInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.home_radioButton2 = new System.Windows.Forms.RadioButton();
            this.mob_radioButton1 = new System.Windows.Forms.RadioButton();
            isMobileLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // isMobileLabel
            // 
            isMobileLabel.AutoSize = true;
            isMobileLabel.Location = new System.Drawing.Point(30, 71);
            isMobileLabel.Name = "isMobileLabel";
            isMobileLabel.Size = new System.Drawing.Size(107, 17);
            isMobileLabel.TabIndex = 1;
            isMobileLabel.Text = "Тип телефона:";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(12, 40);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(125, 17);
            phoneNumLabel.TabIndex = 3;
            phoneNumLabel.Text = "Номер телефона:";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneInfoListBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(143, 40);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(185, 22);
            this.phoneNumTextBox.TabIndex = 2;
            // 
            // savePhoneInfo_button
            // 
            this.savePhoneInfo_button.Location = new System.Drawing.Point(33, 98);
            this.savePhoneInfo_button.Name = "savePhoneInfo_button";
            this.savePhoneInfo_button.Size = new System.Drawing.Size(97, 32);
            this.savePhoneInfo_button.TabIndex = 51;
            this.savePhoneInfo_button.Text = "Сохранить";
            this.savePhoneInfo_button.UseVisualStyleBackColor = true;
            this.savePhoneInfo_button.Click += new System.EventHandler(this.savePhoneInfo_button_Click);
            // 
            // Cancel_button1
            // 
            this.Cancel_button1.Location = new System.Drawing.Point(175, 98);
            this.Cancel_button1.Name = "Cancel_button1";
            this.Cancel_button1.Size = new System.Drawing.Size(97, 32);
            this.Cancel_button1.TabIndex = 52;
            this.Cancel_button1.Text = "Отменить";
            this.Cancel_button1.UseVisualStyleBackColor = true;
            this.Cancel_button1.Click += new System.EventHandler(this.Cancel_button1_Click);
            // 
            // phoneInfoListBindingSource
            // 
            this.phoneInfoListBindingSource.DataSource = typeof(PhoneBookChain.PhoneInfo);
            // 
            // home_radioButton2
            // 
            this.home_radioButton2.AutoSize = true;
            this.home_radioButton2.Location = new System.Drawing.Point(240, 71);
            this.home_radioButton2.Name = "home_radioButton2";
            this.home_radioButton2.Size = new System.Drawing.Size(88, 21);
            this.home_radioButton2.TabIndex = 55;
            this.home_radioButton2.Text = "Домашн.";
            this.home_radioButton2.UseVisualStyleBackColor = true;
            // 
            // mob_radioButton1
            // 
            this.mob_radioButton1.AutoSize = true;
            this.mob_radioButton1.Checked = true;
            this.mob_radioButton1.Location = new System.Drawing.Point(143, 71);
            this.mob_radioButton1.Name = "mob_radioButton1";
            this.mob_radioButton1.Size = new System.Drawing.Size(91, 21);
            this.mob_radioButton1.TabIndex = 54;
            this.mob_radioButton1.TabStop = true;
            this.mob_radioButton1.Text = "Мобильн.";
            this.mob_radioButton1.UseVisualStyleBackColor = true;
            // 
            // AddRowPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 148);
            this.Controls.Add(this.home_radioButton2);
            this.Controls.Add(this.mob_radioButton1);
            this.Controls.Add(this.Cancel_button1);
            this.Controls.Add(this.savePhoneInfo_button);
            this.Controls.Add(isMobileLabel);
            this.Controls.Add(phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Name = "AddRowPhoneForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление номера телефона";
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource phoneInfoListBindingSource;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.Button savePhoneInfo_button;
        private System.Windows.Forms.Button Cancel_button1;
        private System.Windows.Forms.RadioButton home_radioButton2;
        private System.Windows.Forms.RadioButton mob_radioButton1;
    }
}