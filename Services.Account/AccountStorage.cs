using Intreba.Azure.Storage;
using System;

namespace Services.Account
{
    public class AccountStorage
    {
        private readonly TableStorage _storage;
        public AccountStorage()
        {
            _storage = new TableStorage();
        }
        public string DoSomethingWithAnAccount()
        {
            return $"{DateTime.Now.ToLongDateString()} {_storage.DoSomething()}";
        }
    }
}
