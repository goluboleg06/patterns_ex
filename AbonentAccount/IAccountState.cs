public interface IAccountState
{
    void TopUp(double amount);
    void DeductMonthlyFee();
    void ConnectToNetwork();
}
