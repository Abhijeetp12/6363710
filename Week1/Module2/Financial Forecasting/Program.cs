using System;

namespace Financial_Forecasting
{

    class Program
    {
        static void Main()
        {
            FinancialForecast forecaster = new FinancialForecast();

            double initialValue = 10000;           
            double annualGrowthRate = 0.08;      
            int years = 5;                         

            double forecastedValue = forecaster.ForecastFutureValue(initialValue, annualGrowthRate, years);

            Console.WriteLine($"Initial Value: {initialValue}");
            Console.WriteLine($"Forecasted Value after {years} years at {annualGrowthRate * 100}% growth: {forecastedValue:F2}");
        }
    }
}