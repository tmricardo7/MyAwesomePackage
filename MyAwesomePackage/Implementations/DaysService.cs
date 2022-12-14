using MyAwesomePackage.Abstractions;
using MyAwesomePackage.Models;

namespace MyAwesomePackage.Implementations;

public class DateService : IDateService
{
    public Date GetCurrentDate() => new Date
    {
        Year = DateTime.Today.Year,
        Month = DateTime.Today.Month,
        Day = DateTime.Today.Day
    };

    public int GetCurrentDayOfTheMonth() => DateTime.Today.Day;
}