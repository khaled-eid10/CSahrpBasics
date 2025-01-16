﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpBasics
{
    public class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day 
        {  
            get { return day; } 
            set { day = value; } 
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public override string ToString()
        {
            return $"Hiring Date: {Day}/{Month}/{Year}";
        }
    }
}
