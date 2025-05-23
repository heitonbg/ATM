namespace ATM
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.tabPageTransfer = new System.Windows.Forms.TabPage();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.lblTransferAmount = new System.Windows.Forms.Label();
            this.cmbToAccount = new System.Windows.Forms.ComboBox();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.cmbFromAccount = new System.Windows.Forms.ComboBox();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageAccounts.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.tabPageTransfer.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAccounts);
            this.tabControl.Controls.Add(this.tabPageOperations);
            this.tabControl.Controls.Add(this.tabPageTransfer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(584, 361);
            this.tabControl.TabIndex = 0;

            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.Controls.Add(this.btnCreateAccount);
            this.tabPageAccounts.Controls.Add(this.txtInitialBalance);
            this.tabPageAccounts.Controls.Add(this.lblInitialBalance);
            this.tabPageAccounts.Controls.Add(this.txtAccountNumber);
            this.tabPageAccounts.Controls.Add(this.lblAccountNumber);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(576, 335);
            this.tabPageAccounts.TabIndex = 0;
            this.tabPageAccounts.Text = "Счета";
            this.tabPageAccounts.UseVisualStyleBackColor = true;

            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(20, 100);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(150, 30);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "Создать счет";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);

            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(120, 60);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(150, 20);
            this.txtInitialBalance.TabIndex = 3;

            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(20, 63);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(85, 13);
            this.lblInitialBalance.TabIndex = 2;
            this.lblInitialBalance.Text = "Начальный баланс:";

            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(120, 20);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(150, 20);
            this.txtAccountNumber.TabIndex = 1;

            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(20, 23);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(69, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Номер счета:";

            // 
            // tabPageOperations
            // 
            this.tabPageOperations.Controls.Add(this.btnCheckBalance);
            this.tabPageOperations.Controls.Add(this.btnWithdraw);
            this.tabPageOperations.Controls.Add(this.btnDeposit);
            this.tabPageOperations.Controls.Add(this.txtAmount);
            this.tabPageOperations.Controls.Add(this.lblAmount);
            this.tabPageOperations.Controls.Add(this.cmbAccounts);
            this.tabPageOperations.Controls.Add(this.lblAccount);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperations.Size = new System.Drawing.Size(576, 335);
            this.tabPageOperations.TabIndex = 1;
            this.tabPageOperations.Text = "Операции";
            this.tabPageOperations.UseVisualStyleBackColor = true;

            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(220, 100);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(150, 30);
            this.btnCheckBalance.TabIndex = 6;
            this.btnCheckBalance.Text = "Проверить баланс";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);

            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(120, 100);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(80, 30);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Снять";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(20, 100);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(80, 30);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Внести";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(120, 60);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 20);
            this.txtAmount.TabIndex = 3;

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 63);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Сумма:";

            // 
            // cmbAccounts
            // 
            this.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(120, 20);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(150, 21);
            this.cmbAccounts.TabIndex = 1;

            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(20, 23);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(44, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Счет:";

            // 
            // tabPageTransfer
            // 
            this.tabPageTransfer.Controls.Add(this.btnTransfer);
            this.tabPageTransfer.Controls.Add(this.txtTransferAmount);
            this.tabPageTransfer.Controls.Add(this.lblTransferAmount);
            this.tabPageTransfer.Controls.Add(this.cmbToAccount);
            this.tabPageTransfer.Controls.Add(this.lblToAccount);
            this.tabPageTransfer.Controls.Add(this.cmbFromAccount);
            this.tabPageTransfer.Controls.Add(this.lblFromAccount);
            this.tabPageTransfer.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransfer.Name = "tabPageTransfer";
            this.tabPageTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransfer.Size = new System.Drawing.Size(576, 335);
            this.tabPageTransfer.TabIndex = 2;
            this.tabPageTransfer.Text = "Перевод";
            this.tabPageTransfer.UseVisualStyleBackColor = true;

            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(20, 120);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(150, 30);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Перевести";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);

            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(120, 80);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(150, 20);
            this.txtTransferAmount.TabIndex = 5;

            // 
            // lblTransferAmount
            // 
            this.lblTransferAmount.AutoSize = true;
            this.lblTransferAmount.Location = new System.Drawing.Point(20, 83);
            this.lblTransferAmount.Name = "lblTransferAmount";
            this.lblTransferAmount.Size = new System.Drawing.Size(44, 13);
            this.lblTransferAmount.TabIndex = 4;
            this.lblTransferAmount.Text = "Сумма:";

            // 
            // cmbToAccount
            // 
            this.cmbToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToAccount.FormattingEnabled = true;
            this.cmbToAccount.Location = new System.Drawing.Point(120, 50);
            this.cmbToAccount.Name = "cmbToAccount";
            this.cmbToAccount.Size = new System.Drawing.Size(150, 21);
            this.cmbToAccount.TabIndex = 3;

            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(20, 53);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(51, 13);
            this.lblToAccount.TabIndex = 2;
            this.lblToAccount.Text = "На счет:";

            // 
            // cmbFromAccount
            // 
            this.cmbFromAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromAccount.FormattingEnabled = true;
            this.cmbFromAccount.Location = new System.Drawing.Point(120, 20);
            this.cmbFromAccount.Name = "cmbFromAccount";
            this.cmbFromAccount.Size = new System.Drawing.Size(150, 21);
            this.cmbFromAccount.TabIndex = 1;

            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Location = new System.Drawing.Point(20, 23);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(55, 13);
            this.lblFromAccount.TabIndex = 0;
            this.lblFromAccount.Text = "Со счета:";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Банкомат";
            this.tabControl.ResumeLayout(false);
            this.tabPageAccounts.ResumeLayout(false);
            this.tabPageAccounts.PerformLayout();
            this.tabPageOperations.ResumeLayout(false);
            this.tabPageOperations.PerformLayout();
            this.tabPageTransfer.ResumeLayout(false);
            this.tabPageTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAccounts;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPageTransfer;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Label lblTransferAmount;
        private System.Windows.Forms.ComboBox cmbToAccount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.ComboBox cmbFromAccount;
        private System.Windows.Forms.Label lblFromAccount;
    }
}