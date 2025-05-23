using System;
using System.Collections.Generic;

namespace ATM
{
  public sealed class ATM
  {
    private static readonly Lazy<ATM> _instance = new Lazy<ATM>(() => new ATM());
    public static ATM Instance => _instance.Value;

    private Dictionary<string, decimal> _accounts;

    private ATM()
    {
      _accounts = new Dictionary<string, decimal>();
    }

    public void CreateAccount(string accountNumber, decimal initialBalance = 0)
    {
      if (_accounts.ContainsKey(accountNumber))
      {
        throw new Exception("Счет с таким номером уже существует.");
      }

      _accounts[accountNumber] = initialBalance;
    }

    public void Deposit(string accountNumber, decimal amount)
    {
      if (!_accounts.ContainsKey(accountNumber))
      {
        throw new Exception("Счет не найден.");
      }
      if (amount <= 0)
      {
        throw new Exception("Сумма для внесения должна быть положительной.");
      }
      _accounts[accountNumber] += amount;
    }
  }
}
    