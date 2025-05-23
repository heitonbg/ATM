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

    public void Withdraw(string accountNumber, decimal amount)
    {
      if (!_accounts.ContainsKey(accountNumber))
      {
        throw new Exception("Счет не найден.");
      }
    
      if (amount <= 0)
      {
        throw new Exception("Сумма для снятия должна быть положительной.");
      }

      if (_accounts[accountNumber] < amount)
      {
        throw new Exception("Недостаточно средств на счете.");
      }
    
      _accounts[accountNumber] -= amount;
    }

    public void Transfer(string fromAccount, string toAccount, decimal amount)
    {
      if (!_accounts.ContainsKey(fromAccount) || !_accounts.ContainsKey(toAccount))
      {
        throw new Exception("Один из счетов не найден.");
      }

      if (amount <= 0)
      {
        throw new Exception("Сумма перевода должна быть положительной.");
      }

      if (_accounts[fromAccount] < amount)
      {
        throw new Exception("Недостаточно средств для перевода.");
      }
    
      _accounts[fromAccount] -= amount;
      _accounts[toAccount] += amount;
    }

    public decimal CheckBalance(string accountNumber)
    {
      if (!_accounts.ContainsKey(accountNumber))
      {
        throw new Exception("Счет не найден.");
      }

      return _accounts[accountNumber];
    }
  }
}
    