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
            this.просмотрБазДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.viborComboBox = new System.Windows.Forms.ComboBox();
            this.bigRadioButton = new System.Windows.Forms.RadioButton();
            this.littleRadioButton = new System.Windows.Forms.RadioButton();
            this.viborButton = new System.Windows.Forms.Button();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // просмотрБазДанныхToolStripMenuItem
            // 
            this.просмотрБазДанныхToolStripMenuItem.Name = "просмотрБазДанныхToolStripMenuItem";
            this.просмотрБазДанныхToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.просмотрБазДанныхToolStripMenuItem.Text = "Просмотр баз данных";
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 374);
            this.dataGridView1.TabIndex = 1;
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
            this.filterGroupBox.Location = new System.Drawing.Point(44, 428);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(319, 180);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фильтрация";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(6, 101);
            this.filterTextBox.Multiline = true;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(209, 55);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
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
            this.viborComboBox.Location = new System.Drawing.Point(6, 30);
            this.viborComboBox.Name = "viborComboBox";
            this.viborComboBox.Size = new System.Drawing.Size(307, 24);
            this.viborComboBox.TabIndex = 3;
            // 
            // bigRadioButton
            // 
            this.bigRadioButton.AutoSize = true;
            this.bigRadioButton.Location = new System.Drawing.Point(221, 102);
            this.bigRadioButton.Name = "bigRadioButton";
            this.bigRadioButton.Size = new System.Drawing.Size(77, 20);
            this.bigRadioButton.TabIndex = 4;
            this.bigRadioButton.TabStop = true;
            this.bigRadioButton.Text = "Больше";
            this.bigRadioButton.UseVisualStyleBackColor = true;
            // 
            // littleRadioButton
            // 
            this.littleRadioButton.AutoSize = true;
            this.littleRadioButton.Location = new System.Drawing.Point(221, 136);
            this.littleRadioButton.Name = "littleRadioButton";
            this.littleRadioButton.Size = new System.Drawing.Size(79, 20);
            this.littleRadioButton.TabIndex = 5;
            this.littleRadioButton.TabStop = true;
            this.littleRadioButton.Text = "Меньше";
            this.littleRadioButton.UseVisualStyleBackColor = true;
            // 
            // viborButton
            // 
            this.viborButton.Location = new System.Drawing.Point(6, 61);
            this.viborButton.Name = "viborButton";
            this.viborButton.Size = new System.Drawing.Size(307, 34);
            this.viborButton.TabIndex = 6;
            this.viborButton.Text = "Выбрать";
            this.viborButton.UseVisualStyleBackColor = true;
            this.viborButton.Click += new System.EventHandler(this.viborButton_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "1. Занят",
            "2. Свободен"});
            this.statusComboBox.Location = new System.Drawing.Point(6, 102);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(307, 24);
            this.statusComboBox.TabIndex = 7;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(6, 136);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(307, 34);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // PreviewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 646);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PreviewDB";
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.PreviewDB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PreviewDB_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem просмотрБазДанныхToolStripMenuItem;
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
    }
}