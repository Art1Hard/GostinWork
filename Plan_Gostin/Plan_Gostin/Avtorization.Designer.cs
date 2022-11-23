namespace Plan_Gostin
{
    partial class Avtorization
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
            this.groupBoxAvtorization = new System.Windows.Forms.GroupBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelArrow = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonVoiti = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.groupBoxAvtorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAvtorization
            // 
            this.groupBoxAvtorization.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxAvtorization.Controls.Add(this.buttonNazad);
            this.groupBoxAvtorization.Controls.Add(this.buttonVoiti);
            this.groupBoxAvtorization.Controls.Add(this.checkBoxShowPassword);
            this.groupBoxAvtorization.Controls.Add(this.labelPassword);
            this.groupBoxAvtorization.Controls.Add(this.textBoxPassword);
            this.groupBoxAvtorization.Controls.Add(this.labelLogin);
            this.groupBoxAvtorization.Controls.Add(this.textBoxLogin);
            this.groupBoxAvtorization.Controls.Add(this.labelArrow);
            this.groupBoxAvtorization.Controls.Add(this.labelTitle);
            this.groupBoxAvtorization.Location = new System.Drawing.Point(89, 12);
            this.groupBoxAvtorization.Name = "groupBoxAvtorization";
            this.groupBoxAvtorization.Size = new System.Drawing.Size(530, 379);
            this.groupBoxAvtorization.TabIndex = 0;
            this.groupBoxAvtorization.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(91, 147);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(309, 22);
            this.textBoxLogin.TabIndex = 4;
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrow.Location = new System.Drawing.Point(182, 50);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(130, 29);
            this.labelArrow.TabIndex = 3;
            this.labelArrow.Text = "_________";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(148, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(197, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Авторизация";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(202, 105);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(88, 29);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(202, 187);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(102, 29);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(91, 229);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(309, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(406, 233);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(18, 17);
            this.checkBoxShowPassword.TabIndex = 8;
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonVoiti
            // 
            this.buttonVoiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVoiti.Location = new System.Drawing.Point(91, 295);
            this.buttonVoiti.Name = "buttonVoiti";
            this.buttonVoiti.Size = new System.Drawing.Size(129, 56);
            this.buttonVoiti.TabIndex = 9;
            this.buttonVoiti.Text = "Войти";
            this.buttonVoiti.UseVisualStyleBackColor = true;
            this.buttonVoiti.Click += new System.EventHandler(this.buttonVoiti_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNazad.Location = new System.Drawing.Point(271, 295);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(129, 56);
            this.buttonNazad.TabIndex = 10;
            this.buttonNazad.Text = "Назад";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 417);
            this.Controls.Add(this.groupBoxAvtorization);
            this.Name = "Avtorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtorization_Load);
            this.groupBoxAvtorization.ResumeLayout(false);
            this.groupBoxAvtorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAvtorization;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonVoiti;
    }
}