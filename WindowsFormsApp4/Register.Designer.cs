namespace Popcornia
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.registerButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.MaskedTextBox();
            this.address = new System.Windows.Forms.MaskedTextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(111, 282);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(134, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // username
            // 
            this.username.BeepOnError = true;
            this.username.Location = new System.Drawing.Point(114, 89);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(175, 20);
            this.username.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(114, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 20);
            this.name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(114, 141);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(175, 20);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(114, 167);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(175, 20);
            this.email.TabIndex = 4;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(114, 193);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(175, 20);
            this.address.TabIndex = 5;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(114, 219);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(175, 20);
            this.phone.TabIndex = 6;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(114, 245);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(175, 20);
            this.birthdate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Birthday:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.username);
            this.Controls.Add(this.registerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Popcornia || Register";
            this.Load += new System.EventHandler(this.Regsiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.MaskedTextBox username;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.MaskedTextBox email;
        private System.Windows.Forms.MaskedTextBox address;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}