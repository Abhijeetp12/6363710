using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Forecasting
{
    public class FinancialForecast
    {
       
        public double ForecastFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

           
            return ForecastFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }
    }
}
