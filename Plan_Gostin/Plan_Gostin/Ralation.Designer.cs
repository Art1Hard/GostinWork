namespace Plan_Gostin
{
    partial class Ralation
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxAvtorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAvtorization
            // 
            this.groupBoxAvtorization.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxAvtorization.Controls.Add(this.labelEmail);
            this.groupBoxAvtorization.Controls.Add(this.textBoxPhone);
            this.groupBoxAvtorization.Controls.Add(this.labelPhone);
            this.groupBoxAvtorization.Controls.Add(this.textBoxEmail);
            this.groupBoxAvtorization.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAvtorization.Name = "groupBoxAvtorization";
            this.groupBoxAvtorization.Size = new System.Drawing.Size(502, 108);
            this.groupBoxAvtorization.TabIndex = 1;
            this.groupBoxAvtorization.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(71, 58);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 29);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(157, 28);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(309, 22);
            this.textBoxPhone.TabIndex = 6;
            this.textBoxPhone.Text = "+7 (981) 145-89-79";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(26, 21);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(125, 29);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(157, 65);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(309, 22);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "1artem1nazarov1@gmail.com";
            // 
            // Ralation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 136);
            this.Controls.Add(this.groupBoxAvtorization);
            this.Name = "Ralation";
            this.Text = "Связь";
            this.groupBoxAvtorization.ResumeLayout(false);
            this.groupBoxAvtorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAvtorization;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}