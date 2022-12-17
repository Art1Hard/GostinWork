namespace Plan_Gostin
{
    partial class PreviewDB
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.viborButton = new System.Windows.Forms.Button();
            this.littleRadioButton = new System.Windows.Forms.RadioButton();
            this.bigRadioButton = new System.Windows.Forms.RadioButton();
            this.viborComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.viborSortButton = new System.Windows.Forms.Button();
            this.ubivRadioButton = new System.Windows.Forms.RadioButton();
            this.vozrastRadioButton = new System.Windows.Forms.RadioButton();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьТаблицуToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(9, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filterGroupBox.Controls.Add(this.filterButton);
            this.filterGroupBox.Controls.Add(this.statusComboBox);
            this.filterGroupBox.Controls.Add(this.viborButton);
            this.filterGroupBox.Controls.Add(this.littleRadioButton);
            this.filterGroupBox.Controls.Add(this.bigRadioButton);
            this.filterGroupBox.Controls.Add(this.viborComboBox);
            this.filterGroupBox.Controls.Add(this.filterTextBox);
            this.filterGroupBox.ForeColor = System.Drawing.Color.White;
            this.filterGroupBox.Location = new System.Drawing.Point(9, 348);
            this.filterGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterGroupBox.Size = new System.Drawing.Size(132, 146);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фильтрация";
            // 
            // filterButton
            // 
            this.filterButton.ForeColor = System.Drawing.Color.Black;
            this.filterButton.Location = new System.Drawing.Point(4, 110);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(122, 28);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "1. Занят",
            "2. Свободен"});
            this.statusComboBox.Location = new System.Drawing.Point(4, 83);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(123, 21);
            this.statusComboBox.TabIndex = 7;
            // 
            // viborButton
            // 
            this.viborButton.ForeColor = System.Drawing.Color.Black;
            this.viborButton.Location = new System.Drawing.Point(4, 50);
            this.viborButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.littleRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.bigRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.viborComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viborComboBox.Name = "viborComboBox";
            this.viborComboBox.Size = new System.Drawing.Size(123, 21);
            this.viborComboBox.TabIndex = 3;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(4, 107);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterTextBox.Multiline = true;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(123, 35);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sortGroupBox.Controls.Add(this.sortButton);
            this.sortGroupBox.Controls.Add(this.viborSortButton);
            this.sortGroupBox.Controls.Add(this.ubivRadioButton);
            this.sortGroupBox.Controls.Add(this.vozrastRadioButton);
            this.sortGroupBox.Controls.Add(this.sortComboBox);
            this.sortGroupBox.ForeColor = System.Drawing.Color.White;
            this.sortGroupBox.Location = new System.Drawing.Point(195, 348);
            this.sortGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortGroupBox.Size = new System.Drawing.Size(207, 146);
            this.sortGroupBox.TabIndex = 9;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Сортировка";
            // 
            // sortButton
            // 
            this.sortButton.ForeColor = System.Drawing.Color.Black;
            this.sortButton.Location = new System.Drawing.Point(4, 110);
            this.sortButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(194, 28);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // viborSortButton
            // 
            this.viborSortButton.ForeColor = System.Drawing.Color.Black;
            this.viborSortButton.Location = new System.Drawing.Point(4, 50);
            this.viborSortButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viborSortButton.Name = "viborSortButton";
            this.viborSortButton.Size = new System.Drawing.Size(194, 28);
            this.viborSortButton.TabIndex = 6;
            this.viborSortButton.Text = "Выбрать";
            this.viborSortButton.UseVisualStyleBackColor = true;
            this.viborSortButton.Click += new System.EventHandler(this.viborSortButton_Click);
            // 
            // ubivRadioButton
            // 
            this.ubivRadioButton.AutoSize = true;
            this.ubivRadioButton.Location = new System.Drawing.Point(112, 86);
            this.ubivRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ubivRadioButton.Name = "ubivRadioButton";
            this.ubivRadioButton.Size = new System.Drawing.Size(93, 17);
            this.ubivRadioButton.TabIndex = 5;
            this.ubivRadioButton.TabStop = true;
            this.ubivRadioButton.Text = "По убыванию";
            this.ubivRadioButton.UseVisualStyleBackColor = true;
            // 
            // vozrastRadioButton
            // 
            this.vozrastRadioButton.AutoSize = true;
            this.vozrastRadioButton.Location = new System.Drawing.Point(4, 86);
            this.vozrastRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vozrastRadioButton.Name = "vozrastRadioButton";
            this.vozrastRadioButton.Size = new System.Drawing.Size(109, 17);
            this.vozrastRadioButton.TabIndex = 4;
            this.vozrastRadioButton.TabStop = true;
            this.vozrastRadioButton.Text = "По возрастанию";
            this.vozrastRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "1. Номер",
            "2. Статус",
            "3. Доп. Услуги",
            "4. Окончание",
            "5. Цена"});
            this.sortComboBox.Location = new System.Drawing.Point(4, 25);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(195, 21);
            this.sortComboBox.TabIndex = 3;
            // 
            // PreviewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 501);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PreviewDB";
            this.Text = "Просмотр";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreviewDB_FormClosed);
            this.Load += new System.EventHandler(this.PreviewDB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewDB_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton bigRadioButton;
        private System.Windows.Forms.ComboBox viborComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.RadioButton littleRadioButton;
        private System.Windows.Forms.Button viborButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button viborSortButton;
        private System.Windows.Forms.RadioButton ubivRadioButton;
        private System.Windows.Forms.RadioButton vozrastRadioButton;
        private System.Windows.Forms.ComboBox sortComboBox;
    }
}