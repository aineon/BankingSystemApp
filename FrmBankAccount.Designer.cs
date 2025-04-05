namespace BankingSystemApp
{
    partial class FrmBankAccount
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keypadMain = new System.Windows.Forms.GroupBox();
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
            this.gbTrans.SuspendLayout();
            this.keypadMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Verdana Pro Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.lblMessage.Location = new System.Drawing.Point(440, 98);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(694, 81);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnLogout.Location = new System.Drawing.Point(950, 585);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 54);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogoutColourChange_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogoutColourChangeBack_MouseLeave);
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.btnConfirm);
            this.gbTrans.Controls.Add(this.txtbAmount);
            this.gbTrans.Controls.Add(this.label5);
            this.gbTrans.Controls.Add(this.rbWithdraw);
            this.gbTrans.Controls.Add(this.rbDeposit);
            this.gbTrans.Font = new System.Drawing.Font("Verdana Pro Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.gbTrans.Location = new System.Drawing.Point(51, 182);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(698, 373);
            this.gbTrans.TabIndex = 25;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "Transaction Type:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnConfirm.FlatAppearance.BorderSize = 3;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnConfirm.Location = new System.Drawing.Point(318, 232);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(308, 78);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.MouseEnter += new System.EventHandler(this.btnConfirmColourChange_MouseEnter);
            this.btnConfirm.MouseLeave += new System.EventHandler(this.btnConfirmColourChangeBack_MouseLeave);
            // 
            // txtbAmount
            // 
            this.txtbAmount.Location = new System.Drawing.Point(318, 153);
            this.txtbAmount.Name = "txtbAmount";
            this.txtbAmount.Size = new System.Drawing.Size(308, 37);
            this.txtbAmount.TabIndex = 0;
            this.txtbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(189, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount:";
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.rbWithdraw.Location = new System.Drawing.Point(466, 63);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(160, 33);
            this.rbWithdraw.TabIndex = 3;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.rbDeposit.Location = new System.Drawing.Point(194, 63);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(135, 33);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.lblBalance.Location = new System.Drawing.Point(884, 54);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(118, 29);
            this.lblBalance.TabIndex = 24;
            this.lblBalance.Text = "€1234.56";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(676, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Current Balance:";
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.lblAccNo.Location = new System.Drawing.Point(190, 98);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(125, 29);
            this.lblAccNo.TabIndex = 22;
            this.lblAccNo.Text = "12345678";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.lblAccName.Location = new System.Drawing.Point(190, 54);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(198, 29);
            this.lblAccName.TabIndex = 21;
            this.lblAccName.Text = "Dean Winchester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Account Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(46, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Account No:";
            // 
            // keypadMain
            // 
            this.keypadMain.Controls.Add(this.btnDot);
            this.keypadMain.Controls.Add(this.btn0);
            this.keypadMain.Controls.Add(this.btnClear);
            this.keypadMain.Controls.Add(this.btn9);
            this.keypadMain.Controls.Add(this.btn8);
            this.keypadMain.Controls.Add(this.btn7);
            this.keypadMain.Controls.Add(this.btn6);
            this.keypadMain.Controls.Add(this.btn5);
            this.keypadMain.Controls.Add(this.btn4);
            this.keypadMain.Controls.Add(this.btn3);
            this.keypadMain.Controls.Add(this.btn2);
            this.keypadMain.Controls.Add(this.btn1);
            this.keypadMain.Location = new System.Drawing.Point(785, 162);
            this.keypadMain.Name = "keypadMain";
            this.keypadMain.Size = new System.Drawing.Size(349, 393);
            this.keypadMain.TabIndex = 18;
            this.keypadMain.TabStop = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnDot.Location = new System.Drawing.Point(221, 286);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(90, 80);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btnDot.MouseEnter += new System.EventHandler(this.btnDotColourChange_MouseEnter);
            this.btnDot.MouseLeave += new System.EventHandler(this.btnDotColourChangeBack_MouseLeave);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn0.Location = new System.Drawing.Point(125, 286);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 80);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn0.MouseEnter += new System.EventHandler(this.btn0ColourChange_MouseEnter);
            this.btn0.MouseLeave += new System.EventHandler(this.btn0ColourChangeBack_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnClear.Location = new System.Drawing.Point(29, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 80);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClearColourChange_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClearColourChangeBack_MouseLeave);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn9.Location = new System.Drawing.Point(221, 200);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 80);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn9.MouseEnter += new System.EventHandler(this.btn9ColourChange_MouseEnter);
            this.btn9.MouseLeave += new System.EventHandler(this.btn9ColourChangeBack_MouseLeave);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn8.Location = new System.Drawing.Point(125, 200);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 80);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn8.MouseEnter += new System.EventHandler(this.btn8ColourChange_MouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.btn8ColourChangeBack_MouseLeave);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn7.Location = new System.Drawing.Point(29, 200);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 80);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn7.MouseEnter += new System.EventHandler(this.btn7ColourChange_MouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.btn7ColourChangeBack_MouseLeave);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn6.Location = new System.Drawing.Point(221, 114);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 80);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.btn6ColourChange_MouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.btn6ColourChangeBack_MouseLeave);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn5.Location = new System.Drawing.Point(125, 114);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 80);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.btn5ColourChange_MouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.btn5ColourChangeBack_MouseLeave);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn4.Location = new System.Drawing.Point(29, 114);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 80);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.btn4ColourChange_MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.btn4ColourChangeBack_MouseLeave);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn3.Location = new System.Drawing.Point(221, 28);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 80);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.btn3ColourChange_MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.btn3ColourChangBack_MouseLeave);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn2.Location = new System.Drawing.Point(125, 28);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 80);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.btn2ColourChange_MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.btn2ColourChangeBack_MouseLeave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(39)))), ((int)(((byte)(66)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Verdana Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btn1.Location = new System.Drawing.Point(29, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 80);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.mainNumBtn_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.btn1ColourChange_MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1ColourChangeBack_MouseLeave);
            // 
            // FrmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1178, 669);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbTrans);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAccNo);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keypadMain);
            this.Name = "FrmBankAccount";
            this.Text = "FrmBankAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBankAccount_FormClosed);
            this.Load += new System.EventHandler(this.FrmBankAccount_Load);
            this.gbTrans.ResumeLayout(false);
            this.gbTrans.PerformLayout();
            this.keypadMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbTrans;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox keypadMain;
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
    }
}