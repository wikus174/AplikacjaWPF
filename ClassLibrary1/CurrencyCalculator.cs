using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CurrencyCalculator
    {
        public static double ConvertCurrency(double amount, Currency fromCurrency, Currency toCurrency)
        {
            double baseAmount = amount / fromCurrency.exchangeRate; // Convert amount to base currency
            double convertedAmount = baseAmount * toCurrency.exchangeRate; // Convert base amount to target currency
            return convertedAmount;
        }
    }
}
