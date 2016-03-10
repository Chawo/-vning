using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your name : ");
            string name = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
 
            Console.Write("Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime mybirthday = new DateTime(year, month, day);
            var diff = DateTime.Now - mybirthday.Date;
            var YearSinceBirth = diff.Days / 365;

 
            var next = new DateTime(DateTime.Now.Year, mybirthday.Month, mybirthday.Day);
            if (next < DateTime.Today)
                next = next.AddYears(1);
            int numDays = (next - DateTime.Today).Days;
            var nextbirthday = numDays - DateTime.Now.Day;

            var hundredth = mybirthday.Year + 100;
            var objekt = new DateTime(hundredth, mybirthday.Month, mybirthday.Day);
 
            Console.WriteLine("Hello {0},\nYou are {1} years old, and will turn age {2} in couple of {3} days \nYour 100th birthday will be on a {4} on a {5}", name, YearSinceBirth, DateTime.Now.Year - mybirthday.Year, nextbirthday, objekt.ToLongDateString(), mybirthday.DayOfWeek);

            Console.WriteLine(DateTime.Now.ToString());




        }


    }
}
