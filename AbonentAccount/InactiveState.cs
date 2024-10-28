using System;

using System;

public class InactiveState : IAccountState
{
    private InternetAccount account;

    public InactiveState(InternetAccount account)
    {
        this.account = account;
    }

    public void TopUp(double amount)
    {
        account.AdjustBalance(amount);
        Console.WriteLine($"Баланс поповнено на {amount}. Поточний баланс: {account.GetBalance()} грн.");

        if (account.GetBalance() >= 0)
        {
            account.SetState(new ActiveState(account));
            account.SetSpeed(account.GetMaxSpeedLimit());
            Console.WriteLine("Швидкість відновлено.");
        }
    }

    public void DeductMonthlyFee()
    {
        Console.WriteLine("Рахунок не активний. Не можна списати абонплату.");
    }

    public void ConnectToNetwork()
    {
        Console.WriteLine("Рахунок не активний. Поповніть рахунок, щоб підключитися до мережі.");
    }
}
