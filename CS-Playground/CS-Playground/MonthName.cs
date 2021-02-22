using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Playground
{
    public class MonthName
    {
		public static string GetMonthName(int num)
		{
			string monthName;

			switch (num)
			{
				case 1:
					monthName = "January";
					break;
				case 2:
					monthName = "February";
					break;
				case 3:
					monthName = "March";
					break;
				case 4:
					monthName = "April";
					break;
				case 5:
					monthName = "May";
					break;
				case 6:
					monthName = "June";
					break;
				case 7:
					monthName = "July";
					break;
				case 8:
					monthName = "August";
					break;
				case 9:
					monthName = "September";
					break;
				case 10:
					monthName = "October";
					break;
				case 11:
					monthName = "November";
					break;
				case 12:
					monthName = "December";
					break;
                /*TODO: Find out why the code only works with a default label.
                 * Without there is a "Unassigned local variable" error.
                 */
                default:
					monthName = "No such month exists";
					break;
			}
			return monthName;
		}
	}
}
