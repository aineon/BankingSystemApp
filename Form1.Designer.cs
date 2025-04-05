namespace BankingSystemApp
{
    partial class FrmLogin
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
            this.keypadLogin = new System.Windows.Forms.GroupBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPin = new System.Windows.Forms.TextBox();
            this.txtbAccNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keypadLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // keypadLogin
            // 
            this.keypadLogin.Controls.Add(this.btnDot);
            this.keypadLogin.Controls.Add(this.btn0);
            this.keypadLogin.Controls.Add(this.btnClear);
            this.keypadLogin.Controls.Add(this.btn9);
            this.keypadLogin.Controls.Add(this.btn8);
            this.keypadLogin.Controls.Add(this.btn7);
            this.keypadLogin.Controls.Add(this.btn6);
            this.keypadLogin.Controls.Add(this.btn5);
            this.keypadLogin.Controls.Add(this.btn4);
            this.keypadLogin.Controls.Add(this.btn3);
            this.keypadLogin.Controls.Add(this.btn2);
            this.keypadLogin.Controls.Add(this.btn1);
            this.keypadLogin.Location = new System.Drawing.Point(702, 136);
            this.keypadLogin.Name = "keypadLogin";
            this.keypadLogin.Size = new System.Drawing.Size(312, 361);
            this.keypadLogin.TabIndex = 27;
            this.keypadLogin.TabStop = false;
            // 
            // btnDot
            // 
            this.btnDot.Enabled = false;
            this.btnDot.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(205, 275);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(90, 80);
            this.btnDot.TabIndex = 15;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(109, 275);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 80);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(13, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 80);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(205, 191);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 80);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(109, 189);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 80);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(13, 189);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 80);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(205, 108);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 80);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(109, 105);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 80);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(13, 105);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 80);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(205, 19);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 80);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(109, 19);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 80);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(13, 19);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 80);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(502, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 50);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(337, 378);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 50);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(573, 62);
            this.label3.TabIndex = 24;
            this.label3.Text = "Banking App Login";
            // 
            // txtbPin
            // 
            this.txtbPin.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPin.Location = new System.Drawing.Point(352, 287);
            this.txtbPin.MaxLength = 4;
            this.txtbPin.Name = "txtbPin";
            this.txtbPin.PasswordChar = '*';
            this.txtbPin.Size = new System.Drawing.Size(284, 37);
            this.txtbPin.TabIndex = 21;
            this.txtbPin.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.txtbPin.Enter += new System.EventHandler(this.txtbPin_Enter);
            // 
            // txtbAccNo
            // 
            this.txtbAccNo.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAccNo.Location = new System.Drawing.Point(352, 182);
            this.txtbAccNo.MaxLength = 8;
            this.txtbAccNo.Name = "txtbAccNo";
            this.txtbAccNo.Size = new System.Drawing.Size(284, 37);
            this.txtbAccNo.TabIndex = 20;
            this.txtbAccNo.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.txtbAccNo.Enter += new System.EventHandler(this.txtbAccNo_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pin Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Account Number:";
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(1075, 545);
            this.Controls.Add(this.keypadLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbPin);
            this.Controls.Add(this.txtbAccNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.keypadLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox keypadLogin;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPin;
        private System.Windows.Forms.TextBox txtbAccNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

