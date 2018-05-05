using System;
namespace FinalProject.Custom
{
    public class CalculateAge
    {
        public string MovieAge
        {
            get;
            set;
        }

        public string MusicAge
        {
            get;
            set;
        }


        public CalculateAge()
        {

        }

        public string TotalAge()
        {
            decimal decMovieAge;
            if(!Decimal.TryParse(MovieAge, out decMovieAge))
            {
                if(!string.IsNullOrEmpty(MovieAge))
                {
                    throw new Exception("Did you see any of these movies?");
                }
            }

            return (decMovieAge * 2).ToString();
        }
    }
}
