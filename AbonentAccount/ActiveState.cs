using AbonentAccount;
using System;

using System;

public class ActiveState : IAccountState
{
    private InternetAccount account;

    public ActiveState(InternetAccount account)
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
        if (account.GetBalance() >= account.MonthlyFee)
        {
            account.AdjustBalance(-account.MonthlyFee);
            Console.WriteLine($"Абонплата {account.MonthlyFee} грн. списано. Поточний баланс: {account.GetBalance()} грн.");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів для списання абонплати. Швидкість знижено до 0.");
            account.SetState(new InactiveState(account));
            account.SetSpeed(0);
        }
    }

    public void ConnectToNetwork()
    {
        Console.WriteLine($"Швидкість підключення {account.GetCurrentSpeed()} Мбіт/сек");
    }
}

