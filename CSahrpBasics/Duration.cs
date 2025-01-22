using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600; // 1 hour = 3600 seconds
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60; // 1 minute = 60 seconds
            Seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration Time)
            {
                return Hours == Time.Hours && Minutes == Time.Minutes && Seconds == Time.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }
}
