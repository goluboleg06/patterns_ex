using AbonentAccount;
using System;

using System;

public class InternetAccount
{
    public double Balance { get; set; }
    public double MonthlyFee { get; set; }
    public double MaxSpeedLimit { get; set; }
    public double CurrentSpeed { get; set; }
    public IAccountState State { get; set; }

    public InternetAccount(double initialBalance, double monthlyFee, double maxSpeedLimit)
    {
        Balance = initialBalance;
        this.MonthlyFee = monthlyFee;
        this.MaxSpeedLimit = maxSpeedLimit;
        CurrentSpeed = maxSpeedLimit;
        State = new ActiveState(this);
    }

    public void TopUp(double amount)
    {
        State.TopUp(amount);
    }

    public void DeductMonthlyFee()
    {
        State.DeductMonthlyFee();
    }

    public void ConnectToNetwork()
    {
        State.ConnectToNetwork();
    }

    public void SetState(IAccountState state)
    {
        this.State = state;
    }

    public void SetSpeed(double speed)
    {
        CurrentSpeed = speed;
    }

    public double GetBalance()
    {
        return Balance;
    }

    public double GetMaxSpeedLimit()
    {
        return MaxSpeedLimit;
    }

    public double GetCurrentSpeed()
    {
        return CurrentSpeed;
    }

    public void AdjustBalance(double amount)
    {
        Balance += amount;
    }
}
