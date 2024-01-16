internal class ExchangeCalculator
{
    private static void Main()
    {
        //exchange rate to PLN: eur = 4.3746, chf = 4.6797, gbp = 5.0861
        double usd = 3.9963; //fixed exchange rate to PLN
        double eurUsd = 0.92, chfUsd = 0.86, gbpUsd = 0.79;//exchange rates to USD
        double pln, indirectExchange;
        double resultEur, resultChf, resultGbp;
        Console.WriteLine("Prowide PLN to exchange (number grather than 0) and press ENTER button.");
        pln = Convert.ToDouble(Console.ReadLine());
        indirectExchange = pln / usd;
        //Console.WriteLine("{0} PLN = {1:F4} USD", pln, indirectExchange);
        Console.WriteLine("Enter one of supported currency: EUR or CHF or GBP and press ENTER button");
        string moneyCurrency = Console.ReadLine().ToUpper();
        switch (moneyCurrency)
        {
            case "EUR":
                resultEur = indirectExchange * eurUsd;
                Console.WriteLine("You will recieve: {0:F2} EUR", resultEur);
                break;
            case "CHF":
                resultChf = indirectExchange * chfUsd;
                Console.WriteLine("You will recieve: {0:F2} EUR", resultChf);
                break;
            case "GBP":
                resultGbp = indirectExchange * gbpUsd;
                Console.WriteLine("You will recieve: {0:F2} EUR", resultGbp);
                break;
            default:
                Console.WriteLine("The entered data is incorrect. Try again :)");
                break;
        }
    }
}