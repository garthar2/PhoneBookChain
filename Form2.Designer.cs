﻿
namespace PhoneBookChain
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label buildNumLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label flatNumLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label isMobileLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label phoneNumLabel;
            System.Windows.Forms.Label streetNameLabel;
            System.Windows.Forms.Label yearOfBirthLabel;
            this.phoneInfoListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.phoneInfoListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buildNumTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.flatNumTextBox = new System.Windows.Forms.TextBox();
            this.genderCheckBox = new System.Windows.Forms.CheckBox();
            this.isMobileCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.yearOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneBookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            buildNumLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            flatNumLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            isMobileLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            phoneNumLabel = new System.Windows.Forms.Label();
            streetNameLabel = new System.Windows.Forms.Label();
            yearOfBirthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingNavigator)).BeginInit();
            this.phoneInfoListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneInfoListBindingNavigator
            // 
            this.phoneInfoListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phoneInfoListBindingNavigator.BindingSource = this.phoneInfoListBindingSource;
            this.phoneInfoListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phoneInfoListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phoneInfoListBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.phoneInfoListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phoneInfoListBindingNavigatorSaveItem});
            this.phoneInfoListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneInfoListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phoneInfoListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phoneInfoListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phoneInfoListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phoneInfoListBindingNavigator.Name = "phoneInfoListBindingNavigator";
            this.phoneInfoListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phoneInfoListBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.phoneInfoListBindingNavigator.TabIndex = 0;
            this.phoneInfoListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // phoneInfoListBindingNavigatorSaveItem
            // 
            this.phoneInfoListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phoneInfoListBindingNavigatorSaveItem.Enabled = false;
            this.phoneInfoListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneInfoListBindingNavigatorSaveItem.Image")));
            this.phoneInfoListBindingNavigatorSaveItem.Name = "phoneInfoListBindingNavigatorSaveItem";
            this.phoneInfoListBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.phoneInfoListBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 32);
            this.button4.TabIndex = 45;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 32);
            this.button5.TabIndex = 46;
            this.button5.Text = "Отменить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buildNumLabel
            // 
            buildNumLabel.AutoSize = true;
            buildNumLabel.Location = new System.Drawing.Point(23, 47);
            buildNumLabel.Name = "buildNumLabel";
            buildNumLabel.Size = new System.Drawing.Size(76, 17);
            buildNumLabel.TabIndex = 46;
            buildNumLabel.Text = "Build Num:";
            // 
            // buildNumTextBox
            // 
            this.buildNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "BuildNum", true));
            this.buildNumTextBox.Location = new System.Drawing.Point(123, 44);
            this.buildNumTextBox.Name = "buildNumTextBox";
            this.buildNumTextBox.Size = new System.Drawing.Size(200, 22);
            this.buildNumTextBox.TabIndex = 47;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 75);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 48;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(123, 72);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 49;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(23, 103);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 50;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(123, 100);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 51;
            // 
            // flatNumLabel
            // 
            flatNumLabel.AutoSize = true;
            flatNumLabel.Location = new System.Drawing.Point(23, 131);
            flatNumLabel.Name = "flatNumLabel";
            flatNumLabel.Size = new System.Drawing.Size(68, 17);
            flatNumLabel.TabIndex = 52;
            flatNumLabel.Text = "Flat Num:";
            // 
            // flatNumTextBox
            // 
            this.flatNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "FlatNum", true));
            this.flatNumTextBox.Location = new System.Drawing.Point(123, 128);
            this.flatNumTextBox.Name = "flatNumTextBox";
            this.flatNumTextBox.Size = new System.Drawing.Size(200, 22);
            this.flatNumTextBox.TabIndex = 53;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(23, 161);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 54;
            genderLabel.Text = "Gender:";
            // 
            // genderCheckBox
            // 
            this.genderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.phoneBookListBindingSource, "Gender", true));
            this.genderCheckBox.Location = new System.Drawing.Point(123, 156);
            this.genderCheckBox.Name = "genderCheckBox";
            this.genderCheckBox.Size = new System.Drawing.Size(200, 24);
            this.genderCheckBox.TabIndex = 55;
            this.genderCheckBox.Text = "checkBox1";
            this.genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // isMobileLabel
            // 
            isMobileLabel.AutoSize = true;
            isMobileLabel.Location = new System.Drawing.Point(23, 191);
            isMobileLabel.Name = "isMobileLabel";
            isMobileLabel.Size = new System.Drawing.Size(67, 17);
            isMobileLabel.TabIndex = 56;
            isMobileLabel.Text = "Is Mobile:";
            // 
            // isMobileCheckBox
            // 
            this.isMobileCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.phoneBookListBindingSource, "IsMobile", true));
            this.isMobileCheckBox.Location = new System.Drawing.Point(123, 186);
            this.isMobileCheckBox.Name = "isMobileCheckBox";
            this.isMobileCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isMobileCheckBox.TabIndex = 57;
            this.isMobileCheckBox.Text = "checkBox1";
            this.isMobileCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(23, 219);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 58;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(123, 216);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 59;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(23, 247);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(94, 17);
            middleNameLabel.TabIndex = 60;
            middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(123, 244);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.middleNameTextBox.TabIndex = 61;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Location = new System.Drawing.Point(23, 275);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new System.Drawing.Size(86, 17);
            phoneNumLabel.TabIndex = 62;
            phoneNumLabel.Text = "Phone Num:";
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "PhoneNum", true));
            this.phoneNumTextBox.Location = new System.Drawing.Point(123, 272);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneNumTextBox.TabIndex = 63;
            // 
            // streetNameLabel
            // 
            streetNameLabel.AutoSize = true;
            streetNameLabel.Location = new System.Drawing.Point(23, 303);
            streetNameLabel.Name = "streetNameLabel";
            streetNameLabel.Size = new System.Drawing.Size(91, 17);
            streetNameLabel.TabIndex = 64;
            streetNameLabel.Text = "Street Name:";
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookListBindingSource, "StreetName", true));
            this.streetNameTextBox.Location = new System.Drawing.Point(123, 300);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.streetNameTextBox.TabIndex = 65;
            // 
            // yearOfBirthLabel
            // 
            yearOfBirthLabel.AutoSize = true;
            yearOfBirthLabel.Location = new System.Drawing.Point(23, 332);
            yearOfBirthLabel.Name = "yearOfBirthLabel";
            yearOfBirthLabel.Size = new System.Drawing.Size(94, 17);
            yearOfBirthLabel.TabIndex = 66;
            yearOfBirthLabel.Text = "Year Of Birth:";
            // 
            // yearOfBirthDateTimePicker
            // 
            this.yearOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phoneBookListBindingSource, "YearOfBirth", true));
            this.yearOfBirthDateTimePicker.Location = new System.Drawing.Point(123, 328);
            this.yearOfBirthDateTimePicker.Name = "yearOfBirthDateTimePicker";
            this.yearOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.yearOfBirthDateTimePicker.TabIndex = 67;
            // 
            // phoneBookListBindingSource
            // 
            this.phoneBookListBindingSource.DataSource = typeof(PhoneBookChain.PhoneBook);
            // 
            // phoneInfoListBindingSource
            // 
            this.phoneInfoListBindingSource.DataSource = typeof(PhoneBookChain.PhoneInfo);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(buildNumLabel);
            this.Controls.Add(this.buildNumTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(flatNumLabel);
            this.Controls.Add(this.flatNumTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderCheckBox);
            this.Controls.Add(isMobileLabel);
            this.Controls.Add(this.isMobileCheckBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(phoneNumLabel);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(streetNameLabel);
            this.Controls.Add(this.streetNameTextBox);
            this.Controls.Add(yearOfBirthLabel);
            this.Controls.Add(this.yearOfBirthDateTimePicker);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneInfoListBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingNavigator)).EndInit();
            this.phoneInfoListBindingNavigator.ResumeLayout(false);
            this.phoneInfoListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneInfoListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource phoneInfoListBindingSource;
        private System.Windows.Forms.BindingNavigator phoneInfoListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton phoneInfoListBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource phoneBookListBindingSource;
        private System.Windows.Forms.TextBox buildNumTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox flatNumTextBox;
        private System.Windows.Forms.CheckBox genderCheckBox;
        private System.Windows.Forms.CheckBox isMobileCheckBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox phoneNumTextBox;
        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.DateTimePicker yearOfBirthDateTimePicker;
    }
}