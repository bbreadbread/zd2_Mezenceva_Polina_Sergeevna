namespace zd2_Mezenceva_Polina_Sergeevna
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            loadButton = new Button();
            label6 = new Label();
            phoneEditTextBox = new TextBox();
            nameEditTextBox = new TextBox();
            editButton = new Button();
            label5 = new Label();
            label4 = new Label();
            editVisibleButton = new Button();
            searchNameSurnameTextBox = new TextBox();
            searchButton = new Button();
            contactsListBox = new ListBox();
            tabPage1 = new TabPage();
            phoneTextBox = new TextBox();
            label3 = new Label();
            newContactButton = new Button();
            label2 = new Label();
            label1 = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            tabPage3 = new TabPage();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(637, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(editVisibleButton);
            tabPage2.Controls.Add(searchNameSurnameTextBox);
            tabPage2.Controls.Add(searchButton);
            tabPage2.Controls.Add(contactsListBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(629, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Контакты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(phoneEditTextBox);
            panel1.Controls.Add(nameEditTextBox);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(330, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 209);
            panel1.TabIndex = 6;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(21, 52);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(224, 29);
            loadButton.TabIndex = 6;
            loadButton.Text = "Загрузить";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // label6
            // 
            label6.Location = new Point(3, 8);
            label6.Name = "label6";
            label6.Size = new Size(259, 40);
            label6.TabIndex = 5;
            label6.Text = "Выберите из списка контакт для редактирования";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneEditTextBox
            // 
            phoneEditTextBox.Location = new Point(91, 131);
            phoneEditTextBox.Name = "phoneEditTextBox";
            phoneEditTextBox.Size = new Size(154, 27);
            phoneEditTextBox.TabIndex = 4;
            // 
            // nameEditTextBox
            // 
            nameEditTextBox.Location = new Point(91, 87);
            nameEditTextBox.Name = "nameEditTextBox";
            nameEditTextBox.Size = new Size(154, 27);
            nameEditTextBox.TabIndex = 3;
            // 
            // editButton
            // 
            editButton.Location = new Point(21, 164);
            editButton.Name = "editButton";
            editButton.Size = new Size(224, 29);
            editButton.TabIndex = 2;
            editButton.Text = "Сохранить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 134);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 1;
            label5.Text = "Номер:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 90);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 0;
            label4.Text = "ИФ: ";
            // 
            // editVisibleButton
            // 
            editVisibleButton.Location = new Point(330, 111);
            editVisibleButton.Name = "editVisibleButton";
            editVisibleButton.Size = new Size(265, 45);
            editVisibleButton.TabIndex = 5;
            editVisibleButton.Text = "Редактирование";
            editVisibleButton.UseVisualStyleBackColor = true;
            editVisibleButton.Click += editButton_Click;
            // 
            // searchNameSurnameTextBox
            // 
            searchNameSurnameTextBox.Font = new Font("Segoe UI", 12F);
            searchNameSurnameTextBox.Location = new Point(330, 20);
            searchNameSurnameTextBox.Name = "searchNameSurnameTextBox";
            searchNameSurnameTextBox.Size = new Size(265, 34);
            searchNameSurnameTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(330, 60);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(265, 45);
            searchButton.TabIndex = 2;
            searchButton.Text = "Поиск по ИФ";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // contactsListBox
            // 
            contactsListBox.Dock = DockStyle.Left;
            contactsListBox.FormattingEnabled = true;
            contactsListBox.Location = new Point(3, 3);
            contactsListBox.Name = "contactsListBox";
            contactsListBox.Size = new Size(296, 411);
            contactsListBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(phoneTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(newContactButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(surnameTextBox);
            tabPage1.Controls.Add(nameTextBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(629, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавить контакт";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F);
            phoneTextBox.Location = new Point(79, 191);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(466, 34);
            phoneTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(79, 160);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 5;
            label3.Text = "Номер телефона";
            // 
            // newContactButton
            // 
            newContactButton.Font = new Font("Segoe UI", 12F);
            newContactButton.Location = new Point(79, 266);
            newContactButton.Name = "newContactButton";
            newContactButton.Size = new Size(466, 45);
            newContactButton.TabIndex = 4;
            newContactButton.Text = "Добавить новый контакт";
            newContactButton.UseVisualStyleBackColor = true;
            newContactButton.Click += newContactButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(332, 81);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(79, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Font = new Font("Segoe UI", 12F);
            surnameTextBox.Location = new Point(332, 112);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(213, 34);
            surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 12F);
            nameTextBox.Location = new Point(79, 112);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(213, 34);
            nameTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(629, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Закрыть";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(172, 193);
            label7.Name = "label7";
            label7.Size = new Size(327, 35);
            label7.TabIndex = 0;
            label7.Text = "Пока!! (нажми для выхода)";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(134, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button searchButton;
        private TextBox searchNameSurnameTextBox;
        private Label label2;
        private Label label1;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Panel panel1;
        private Button editVisibleButton;
        private ListBox contactsListBox;
        private Button newContactButton;
        private TextBox phoneTextBox;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private TextBox phoneEditTextBox;
        private TextBox nameEditTextBox;
        private Button editButton;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button loadButton;
        private TabPage tabPage3;
        private Label label7;
    }
}
