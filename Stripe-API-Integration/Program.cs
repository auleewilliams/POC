using System;
using System.Linq;
using Stripe;

namespace Stripe_API_Integration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var apiKey = "";
            var stripe = new StripeClient(apiKey);

            var chargeService = new ChargeService(stripe);
            var chargeId = "";
            var charge = chargeService.Get(chargeId);

            Console.WriteLine("Charge");
            Console.WriteLine($"Amount: ${charge.Amount}");

            var payoutService = new PayoutService(stripe);
            var payoutId = "";
            var payout = payoutService.Get(payoutId);

            Console.WriteLine($"Payout: {payoutId}");
            Console.WriteLine($"Date Paid: {payout.ArrivalDate.ToString()}");
            

            var balanceTransactionService = new BalanceTransactionService(stripe);
            var requestOptions = new BalanceTransactionListOptions {Payout = payoutId, Limit = 100};
            var transactionList = balanceTransactionService.List(requestOptions);

            Console.WriteLine($"Transactions: {transactionList.Count()}");

        }
    }
}