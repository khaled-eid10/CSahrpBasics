using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics
{
    public class Duration
    {
        int hours;
        int minutes;
        int seconds;

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int input) 
        {
            Hours = input / 3600;
            input %= 3600;
            Minutes = input / 60;
            Seconds = input %= 60;
        }

        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"Minutes:{Minutes},Seconds:{Seconds}";
            }
            return $"Hours:{Hours},Minutes:{Minutes},Seconds:{Seconds}";
        }

        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration
            {

                Hours = a.Hours + b.Hours,
                Minutes = a.Minutes + b.Minutes,
                Seconds = a.Seconds + b.Seconds
            };
        }
        public static Duration operator ++(Duration duration)
        {
            if (duration is not null)
                return duration++;

            return duration;
            
        }
        public static Duration operator --(Duration duration)
        {

            if (duration is not null)
                return duration--;

            return duration;
        }
        public static Duration operator +(Duration a, int b)
        {
            return new Duration(a.Hours * 3600 + a.Minutes * 60 + a.Seconds + b);
        }
        public static Duration operator +(int a, Duration b)
        {
            return new Duration(b.Hours * 3600 + b.Minutes * 60 + b.Seconds + a);
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration
            {

                Hours = a.Hours - b.Hours,
                Minutes = a.Minutes - b.Minutes,
                Seconds = a.Seconds - b.Seconds
            };
        }

        public static bool operator >(Duration a, Duration b)
        {
            if (a.Hours == b.Hours)
                return a?.Hours > b?.Hours;
            else if (a.Minutes == b.Minutes)
                return a?.Minutes > b?.Minutes;
            else if (a.Seconds == b.Seconds)
                return a?.Seconds > b?.Seconds;
            else 
                return b.Hours > a.Hours & b.Minutes > a.Minutes & a.Seconds > b.Seconds;

        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hours == b.Hours)
                return a?.Hours < b?.Hours;
            else if (a.Minutes == b.Minutes)
                return a?.Minutes < b?.Minutes;
            else if (a.Seconds == b.Seconds)
                return a?.Seconds < b?.Seconds;
            else
                return b.Hours < a.Hours & b.Minutes < a.Minutes & a.Seconds < b.Seconds;

        }

        public static bool operator >=(Duration a, Duration b)
        {
            return (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) >=
                   (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
        }

        // Overload <= operator
        public static bool operator <=(Duration a, Duration b)
        {
            return (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) <=
                   (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
        }

        public static implicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }
    }
    


}
