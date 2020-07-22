using System;

namespace Command
{
    public class WithdrawCommand : ICommand
    {
        private readonly Account _account;

        private readonly decimal _amount;

        public WithdrawCommand(Account account, decimal amount)
        {
            _account = account;

            _amount = amount;
        }

        public void Execute()
        {
            _account.Withdraw(_amount);

            Console.WriteLine($"取款{_amount}元。");
        }
    }
}
