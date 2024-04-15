namespace Omega.Presentation_Tier
{
    partial class NewUserForm
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
            this.username = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.pwdTb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jeSpravce = new System.Windows.Forms.RadioButton();
            this.jePokladnik = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(74, 90);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(137, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Uživatelské jméno";
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(215, 86);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(206, 26);
            this.usernameTb.TabIndex = 1;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(215, 314);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 36);
            this.add.TabIndex = 2;
            this.add.Text = "Přidat";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // pwdTb
            // 
            this.pwdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTb.Location = new System.Drawing.Point(215, 133);
            this.pwdTb.Name = "pwdTb";
            this.pwdTb.PasswordChar = '*';
            this.pwdTb.Size = new System.Drawing.Size(206, 26);
            this.pwdTb.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(74, 135);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(50, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Heslo";
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTb.Location = new System.Drawing.Point(215, 176);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(206, 26);
            this.nameTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jméno zam.";
            // 
            // surnameTb
            // 
            this.surnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTb.Location = new System.Drawing.Point(215, 218);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(206, 26);
            this.surnameTb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Příjmení";
            // 
            // jeSpravce
            // 
            this.jeSpravce.AutoSize = true;
            this.jeSpravce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeSpravce.Location = new System.Drawing.Point(215, 266);
            this.jeSpravce.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jeSpravce.Name = "jeSpravce";
            this.jeSpravce.Size = new System.Drawing.Size(85, 24);
            this.jeSpravce.TabIndex = 21;
            this.jeSpravce.TabStop = true;
            this.jeSpravce.Text = "Správce";
            this.jeSpravce.UseVisualStyleBackColor = true;
            // 
            // jePokladnik
            // 
            this.jePokladnik.AutoSize = true;
            this.jePokladnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jePokladnik.Location = new System.Drawing.Point(332, 266);
            this.jePokladnik.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.jePokladnik.Name = "jePokladnik";
            this.jePokladnik.Size = new System.Drawing.Size(95, 24);
            this.jePokladnik.TabIndex = 22;
            this.jePokladnik.TabStop = true;
            this.jePokladnik.Text = "Pokladník";
            this.jePokladnik.UseVisualStyleBackColor = true;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 386);
            this.Controls.Add(this.jePokladnik);
            this.Controls.Add(this.jeSpravce);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwdTb);
            this.Controls.Add(this.password);
            this.Controls.Add(this.add);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.username);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox pwdTb;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton jeSpravce;
        private System.Windows.Forms.RadioButton jePokladnik;
    }
}