using Nancy;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WeekdayFinder.Objects
{
  public class Timeline
  {

    public string FindWeekday(int day, int month, int year)
    {
      Dictionary<int, int> months = new Dictionary<int, int>() {{1, 0}, {2, 31}, {3, 59}, {4, 90}, {5, 120}, {6, 151}, {7, 181}, {8, 212}, {9, 243}, {10, 273}, {11, 304}, {12, 334}};

      Dictionary<int, string> numberToWeekday = new Dictionary<int, string>() {{0, "StirFriday"}, {1, "Saturday"}, {2, "Sunday Funday"}, {3, "Monday ugh"}, {4, "Taco Tuesday"}, {5, "Humpday"}, {6, "Thursday"}};
      int completeYears = year - 1;
      int numberLeapYears = (completeYears/4) - (completeYears/100) + (completeYears/400);
      if(month>2&&((year%400==0)||(year%4==0&&year%100!=0)))
      {
        numberLeapYears+=1;
      }
      int numberofDays = completeYears*365 + months[month] + day + numberLeapYears + 2;
      string dayOfWeek=numberToWeekday[numberofDays%7];

      return dayOfWeek;
    }
  }
}
