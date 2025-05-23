using System;
using System.Windows.Forms;

namespace ATM
{
  public partial class Form1 : Form
  {
    private readonly ATM _atm;

    public Form1()
    {
      InitializeComponent();
      _atm = ATM.Instance;
      InitializeUI();
      RefreshAccountsList();
    }

    private void InitializeUI()
    {
      this.Text = "Банкомат";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.MinimumSize = new System.Drawing.Size(600, 400);
    }

    private void RefreshAccountsList()
    {
      var accounts = _atm.GetAccountNumbers();
      cmbAccounts.DataSource = new System.ComponentModel.BindingList<string>(accounts);
      cmbFromAccount.DataSource = new System.ComponentModel.BindingList<string>(accounts);
      cmbToAccount.DataSource = new System.ComponentModel.BindingList<string>(accounts);
    }

    private void btnCreateAccount_Click(object sender, EventArgs e)
    {
      try
      {
        string accountNumber = txtAccountNumber.Text;
        if (string.IsNullOrWhiteSpace(accountNumber))
        {
          throw new Exception("Введите номер счета");
        }

        if (!decimal.TryParse(txtInitialBalance.Text, out decimal initialBalance))
        {
          initialBalance = 0;
        }

        _atm.CreateAccount(accountNumber, initialBalance);
        MessageBox.Show($"Счет {accountNumber} создан с балансом {initialBalance:C}", "Успех");
        RefreshAccountsList();
        txtAccountNumber.Clear();
        txtInitialBalance.Clear();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка");
      }
    }

    private void btnDeposit_Click(object sender, EventArgs e)
    {
      try
      {
        string account = cmbAccounts.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(account))
        {
          throw new Exception("Выберите счет");
        }

        if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
        {
          throw new Exception("Введите корректную сумму");
        }

        _atm.Deposit(account, amount);
        MessageBox.Show($"Внесено {amount:C}. Новый баланс: {_atm.CheckBalance(account):C}", "Успех");
        txtAmount.Clear();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка");
      }
    }

    private void btnWithdraw_Click(object sender, EventArgs e)
    {
      try
      {
        string account = cmbAccounts.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(account))
          throw new Exception("Выберите счет");

        if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
          throw new Exception("Введите корректную сумму");

        _atm.Withdraw(account, amount);
        MessageBox.Show($"Снято {amount:C}. Новый баланс: {_atm.CheckBalance(account):C}", "Успех");
        txtAmount.Clear();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка");
      }
    }

    private void btnCheckBalance_Click(object sender, EventArgs e)
    {
      try
      {
        string account = cmbAccounts.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(account))
        {
          throw new Exception("Выберите счет");
        }

        decimal balance = _atm.CheckBalance(account);
        MessageBox.Show($"Баланс счета {account}: {balance:C}", "Баланс");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка");
      }
    }

    private void btnTransfer_Click(object sender, EventArgs e)
    {
      try
      {
        string fromAccount = cmbFromAccount.SelectedItem?.ToString();
        string toAccount = cmbToAccount.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(fromAccount) || string.IsNullOrEmpty(toAccount))
        {
          throw new Exception("Выберите оба счета");
        }

        if (fromAccount == toAccount)
        {
          throw new Exception("Нельзя перевести на тот же счет");
        }

        if (!decimal.TryParse(txtTransferAmount.Text, out decimal amount) || amount <= 0)
        {
          throw new Exception("Введите корректную сумму");
        }

        _atm.Transfer(fromAccount, toAccount, amount);
        MessageBox.Show($"Переведено {amount:C}\n" +
                      $"Со счета {fromAccount}: {_atm.CheckBalance(fromAccount):C}\n" +
                      $"На счет {toAccount}: {_atm.CheckBalance(toAccount):C}", "Успех");
        txtTransferAmount.Clear();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка перевода");
      }
    }
  }
}