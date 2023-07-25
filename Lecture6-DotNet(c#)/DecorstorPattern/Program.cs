using DecoratorPattern;

internal class Program
{
    static void Main(string[] args)
    {
        IATM atm = new BaseATM();

        atm = new CardScannerDecorator(atm);
        atm = new PinValidationDecorator(atm);

        atm.InsertCard();
        atm.EnterPin();
        atm.WithdrawCash();
    }
}
