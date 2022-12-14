namespace Plan_Gostin
{
    partial class Reservation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.просмотрБазДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.viborButton = new System.Windows.Forms.Button();
            this.littleRadioButton = new System.Windows.Forms.RadioButton();
            this.bigRadioButton = new System.Windows.Forms.RadioButton();
            this.viborComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрБазДанныхToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрБазДанныхToolStripMenuItem
            // 
            this.просмотрБазДанныхToolStripMenuItem.Name = "просмотрБазДанныхToolStripMenuItem";
            this.просмотрБазДанныхToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.просмотрБазДанныхToolStripMenuItem.Text = "Просмотр баз данных";
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(10, 94);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(187, 23);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(57, 68);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(140, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(10, 123);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Освободить";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(57, 16);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(140, 20);
            this.roomTextBox.TabIndex = 11;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(57, 42);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(140, 20);
            this.statusTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Номер:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buyButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.roomTextBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 159);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Бронирование";
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.filterButton);
            this.filterGroupBox.Controls.Add(this.statusComboBox);
            this.filterGroupBox.Controls.Add(this.viborButton);
            this.filterGroupBox.Controls.Add(this.littleRadioButton);
            this.filterGroupBox.Controls.Add(this.bigRadioButton);
            this.filterGroupBox.Controls.Add(this.viborComboBox);
            this.filterGroupBox.Controls.Add(this.filterTextBox);
            this.filterGroupBox.Location = new System.Drawing.Point(361, 357);
            this.filterGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.filterGroupBox.Size = new System.Drawing.Size(132, 146);
            this.filterGroupBox.TabIndex = 17;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фильтрация";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(4, 110);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(122, 28);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "1. Занят",
            "2. Свободен"});
            this.statusComboBox.Location = new System.Drawing.Point(4, 83);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(123, 21);
            this.statusComboBox.TabIndex = 7;
            // 
            // viborButton
            // 
            this.viborButton.Location = new System.Drawing.Point(4, 50);
            this.viborButton.Margin = new System.Windows.Forms.Padding(2);
            this.viborButton.Name = "viborButton";
            this.viborButton.Size = new System.Drawing.Size(122, 28);
            this.viborButton.TabIndex = 6;
            this.viborButton.Text = "Выбрать";
            this.viborButton.UseVisualStyleBackColor = true;
            this.viborButton.Click += new System.EventHandler(this.viborButton_Click);
            // 
            // littleRadioButton
            // 
            this.littleRadioButton.AutoSize = true;
            this.littleRadioButton.Location = new System.Drawing.Point(68, 86);
            this.littleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.littleRadioButton.Name = "littleRadioButton";
            this.littleRadioButton.Size = new System.Drawing.Size(66, 17);
            this.littleRadioButton.TabIndex = 5;
            this.littleRadioButton.TabStop = true;
            this.littleRadioButton.Text = "Меньше";
            this.littleRadioButton.UseVisualStyleBackColor = true;
            // 
            // bigRadioButton
            // 
            this.bigRadioButton.AutoSize = true;
            this.bigRadioButton.Location = new System.Drawing.Point(4, 86);
            this.bigRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.bigRadioButton.Name = "bigRadioButton";
            this.bigRadioButton.Size = new System.Drawing.Size(64, 17);
            this.bigRadioButton.TabIndex = 4;
            this.bigRadioButton.TabStop = true;
            this.bigRadioButton.Text = "Больше";
            this.bigRadioButton.UseVisualStyleBackColor = true;
            // 
            // viborComboBox
            // 
            this.viborComboBox.FormattingEnabled = true;
            this.viborComboBox.Items.AddRange(new object[] {
            "1. Номер",
            "2. Статус",
            "3. Доп. Услуги",
            "4. Окончание",
            "5. Цена"});
            this.viborComboBox.Location = new System.Drawing.Point(4, 24);
            this.viborComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.viborComboBox.Name = "viborComboBox";
            this.viborComboBox.Size = new System.Drawing.Size(123, 21);
            this.viborComboBox.TabIndex = 3;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(4, 107);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filterTextBox.Multiline = true;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(123, 35);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged_1);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 514);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reservation";
            this.Text = "Бронирование";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reservation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрБазДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button viborButton;
        private System.Windows.Forms.RadioButton littleRadioButton;
        private System.Windows.Forms.RadioButton bigRadioButton;
        private System.Windows.Forms.ComboBox viborComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
    }
}