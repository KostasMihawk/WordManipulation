using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordManipulation.Models
{
    public class DayCalculator
    {
        public string CalculateDesiredDayString(SelectTime selectTime)
        {
            if ((selectTime == SelectTime.Today))
            {
                return DateTime.Today.Day.ToString();
            }
            else if (selectTime == SelectTime.Tomorrow)
            {
                return DateTime.Today.AddDays(1).Day.ToString();
            }
            else return "  ";
        }

        public int CalculateDesiredDay(SelectTime selectTime)
        {
            if ((selectTime == SelectTime.Today))
            {
                return DateTime.Today.Day;
            }
            else if (selectTime == SelectTime.Tomorrow)
            {
                return DateTime.Today.AddDays(1).Day;
            }
            else return 0;
        }

        public int CalculateDesiredMonth(SelectTime selectTime)
        {
            if (selectTime == SelectTime.Today)
            {
                return DateTime.Today.Month;
            }
            else if(selectTime == SelectTime.Tomorrow)
            {
                return DateTime.Today.AddDays(1).Month;
            }
            else
            {
                return 0;
            }
        }

        public int CalculateDesiredYear(SelectTime selectTime)
        {
            if (selectTime == SelectTime.Today)
            {
                return DateTime.Today.Year;
            }
            else if (selectTime == SelectTime.Tomorrow)
            {
                return DateTime.Today.AddDays(1).Year;
            }
            else
            {
                return DateTime.Today.AddDays(7).Year;
            }
        }

        public int CalculateDaysName(SelectTime selectTime)
        {
            if (selectTime == SelectTime.Today)
            {
                return (int)DateTime.Today.DayOfWeek;
            }
            else if (selectTime == SelectTime.Tomorrow)
            {
                return (int)DateTime.Today.AddDays(1).DayOfWeek;
            }
            else
            {
                return -1;
            }
        }
    }
}