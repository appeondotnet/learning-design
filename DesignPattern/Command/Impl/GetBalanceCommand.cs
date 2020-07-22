using System;

namespace Command
{
    public class GetBalanceCommand : ICommand
    {
        private readonly Account _account;

        public GetBalanceCommand(Account account)
        {
            _account = account;
        }

        public void Execute()
        {
            decimal balance = _account.GetBalance();

            Console.WriteLine($"余额{balance}元。");
        }
    }
}
