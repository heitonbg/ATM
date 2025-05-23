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
    }
}