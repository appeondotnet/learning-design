using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            ICommand depositCmd = new DepositCommand(account, 100);

            ICommand withdrawCmd = new WithdrawCommand(account, 50);

            ICommand balanceCmd = new GetBalanceCommand(account);

            Invoker invoker = new Invoker();

            invoker.ExecuteCommand(depositCmd);

            invoker.ExecuteCommand(balanceCmd);

            invoker.ExecuteCommand(withdrawCmd);

            invoker.ExecuteCommand(balanceCmd);

            Console.Read();
        }
    }
}
