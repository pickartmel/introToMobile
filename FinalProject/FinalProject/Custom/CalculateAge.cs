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
            decimal decMovieAge, decMusicAge;
            if(!Decimal.TryParse(MovieAge, out decMovieAge))
            {
                if(!string.IsNullOrEmpty(MovieAge))
                {
                    throw new Exception("Did you see any of these movies?");
                }
            }
            if(!Decimal.TryParse(MusicAge, out decMusicAge))
            {
                if(!string.IsNullOrEmpty(MusicAge))
                {
                    throw new Exception("Did you see any of these movies?");
                }
            }

            return (((decMovieAge * 3) + (decMusicAge *3)) /2).ToString();
        }
    }
}
