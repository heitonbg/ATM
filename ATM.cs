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
  }
}
    