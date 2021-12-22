using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {
        public string startAsString;
        public string endAsString;

        public int CalculateDifference(string startAsString, string endAsString)
        {
            DateTime startDate = DateTime.Parse(startAsString);
            DateTime endDate = DateTime.Parse(endAsString);
            int result = (int)Math.Abs((startDate - endDate).TotalDays);

            return result;
        }
    }
}
