using System;
namespace DateNight.Custom
{
    public class DateCalculator
    {
        public string CoffeeCost
        {
            get;
            set;
        }
        public string DinnerCost
        {
            get;
            set;
        }
        public string MovieCost
        {
            get;
            set;
        }
        public string GetTotalCost()
        {
            decimal decCoffeeCost, decMovieCost, decDinnerCost;

            if (!Decimal.TryParse(CoffeeCost, out decCoffeeCost))
            {
                if (!string.IsNullOrEmpty(CoffeeCost))
                {
                    throw new Exception("Invalid Coffee Cost");
                }
            }

            if (!Decimal.TryParse(DinnerCost, out decDinnerCost))
            {
                if (!string.IsNullOrEmpty(DinnerCost))
                {
                    throw new Exception("Invalid Dinner Cost");
                }
            }

            if (!Decimal.TryParse(MovieCost, out decMovieCost))
            {
                if (!string.IsNullOrEmpty(MovieCost))
                {
                    throw new Exception("Invalid Movie Cost");
                }
            }

            return (decCoffeeCost + decDinnerCost + decMovieCost).ToString("C");

        }
    }
}
