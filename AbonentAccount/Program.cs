using System;
namespace AbonentAccount
{
    
class Program
{
    static void Main(string[] args)
    {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            InternetAccount account = new InternetAccount(20, 25, 100);

        account.ConnectToNetwork();
        account.DeductMonthlyFee();
        account.ConnectToNetwork();

        account.TopUp(10);
        account.ConnectToNetwork();
    }
}
}
