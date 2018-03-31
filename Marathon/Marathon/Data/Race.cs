using System;
namespace Marathon.Data
{
    public class RaceColletction
    {
        public Race[]races 
        {
            get;
            set;
        }
    }
    public class Race
    {
        public int id
        {
            get;
            set;
        }
        public string race_name
        {
            get;
            set;
        }
    }
}
