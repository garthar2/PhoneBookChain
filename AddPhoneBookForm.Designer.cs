
namespace PhoneBookChain
{
    partial class AddPhoneBookForm
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumLabel;
            System.Windows.Forms.Label streetNameLabel;
            this.CredTripleDot_button1 = new System.Windows.Forms.Button();
            this.AdrTripleDot_button2 = new System.Windows.Forms.Button();
            this.PhoneTripleDot_button3 = new System.Windows.Forms.Button();
            this.save_button4 = new System.Windows.Forms.Button();
            this.cancel_button5 = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneBookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            emailLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            streetNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(30, 209);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 17);
            emailLabel.TabIndex = 48;
            emailLabel.Text = "email";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(30, 56);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(42, 17);
            lastNameLabel.TabIndex = 58;
            lastNameLabel.Text = "ФИО";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(24, 107);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(48, 17);
            phoneNumLabel.TabIndex = 62;
            phoneNumLabel.Text = "Адрес";
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new System.Drawing.Point(4, 155);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new System.Drawing.Size(68, 17);
            streetNameLabel.TabIndex = 64;
            streetNameLabel.Text = "Телефон";
            // 
            // CredTripleDot_button1
            // 
            this.CredTripleDot_button1.Location = new System.Drawing.Point(401, 49);
            this.CredTripleDot_button1.Name = "CredTripleDot_button1";
            this.CredTripleDot_button1.Size = new System.Drawing.Size(75, 31);
            this.CredTripleDot_button1.TabIndex = 21;
            this.CredTripleDot_button1.Text = "...";
            this.CredTripleDot_button1.UseVisualStyleBackColor = true;
            this.CredTripleDot_button1.Click += new System.EventHandler(this.CredTripleDot_button1_Click);
            // 
            // AdrTripleDot_button2
            // 
            this.AdrTripleDot_button2.Location = new System.Drawing.Point(401, 100);
            this.AdrTripleDot_button2.Name = "AdrTripleDot_button2";
            this.AdrTripleDot_button2.Size = new System.Drawing.Size(75, 31);
            this.AdrTripleDot_button2.TabIndex = 22;
            this.AdrTripleDot_button2.Text = "...";
            this.AdrTripleDot_button2.UseVisualStyleBackColor = true;
            this.AdrTripleDot_button2.Click += new System.EventHandler(this.AdrTripleDot_button2_Click);
            // 
            // PhoneTripleDot_button3
            // 
            this.PhoneTripleDot_button3.Location = new System.Drawing.Point(401, 148);
            this.PhoneTripleDot_button3.Name = "PhoneTripleDot_button3";
            this.PhoneTripleDot_button3.Size = new System.Drawing.Size(75, 31);
            this.PhoneTripleDot_button3.TabIndex = 23;
            this.PhoneTripleDot_button3.Text = "...";
            this.PhoneTripleDot_button3.UseVisualStyleBackColor = true;
            this.PhoneTripleDot_button3.Click += new System.EventHandler(this.PhoneTripleDot_button3_Click);
            // 
            // save_button4
            // 
            this.save_button4.Location = new System.Drawing.Point(78, 264);
            this.save_button4.Name = "save_button4";
            this.save_button4.Size = new System.Drawing.Size(97, 32);
            this.save_button4.TabIndex = 45;
            this.save_button4.Text = "Сохранить";
            this.save_button4.UseVisualStyleBackColor = true;
            this.save_button4.Click += new System.EventHandler(this.save_button4_Click);
            // 
            // cancel_button5
            // 
            this.cancel_button5.Location = new System.Drawing.Point(298, 264);
            this.cancel_button5.Name = "cancel_button5";
            this.cancel_button5.Size = new System.Drawing.Size(97, 32);
            this.cancel_button5.TabIndex = 46;
            this.cancel_button5.Text = "Отменить";
            this.cancel_button5.UseVisualStyleBackColor = true;
            this.cancel_button5.Click += new System.EventHandler(this.cancel_button5_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(77, 206);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(318, 22);
            this.emailTextBox.TabIndex = 49;
            // 
            // phoneBookListBindingSource
            // 
            this.phoneBookListBindingSource.DataSource = typeof(PhoneBookChain.PhoneBook);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(78, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(317, 22);
            this.lastNameTextBox.TabIndex = 59;
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(78, 155);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(317, 22);
            this.phoneNumTextBox.TabIndex = 63;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "StreetName", true));
            this.addressTextBox.Location = new System.Drawing.Point(78, 104);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(317, 22);
            this.addressTextBox.TabIndex = 65;
            // 
            // phoneInfoListBindingSource
            // 
            this.phoneInfoListBindingSource.DataSource = typeof(PhoneBookChain.PhoneInfo);
            // 
            // AddPhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 339);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(streetNameLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.cancel_button5);
            this.Controls.Add(this.save_button4);
            this.Controls.Add(this.PhoneTripleDot_button3);
            this.Controls.Add(this.AdrTripleDot_button2);
            this.Controls.Add(this.CredTripleDot_button1);
            this.Name = "AddPhoneBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление в телефонный справочник (обобщающий класс)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPhoneBookForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource phoneInfoListBindingSource;
        private System.Windows.Forms.Button CredTripleDot_button1;
        private System.Windows.Forms.Button AdrTripleDot_button2;
        private System.Windows.Forms.Button PhoneTripleDot_button3;
        private System.Windows.Forms.Button save_button4;
        private System.Windows.Forms.Button cancel_button5;
        private System.Windows.Forms.BindingSource phoneBookListBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}