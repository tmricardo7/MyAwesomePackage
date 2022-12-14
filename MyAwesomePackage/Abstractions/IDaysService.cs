using MyAwesomePackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomePackage.Abstractions;

public interface IDateService
{
    Date GetCurrentDate();
    int GetCurrentDayOfTheMonth();
}
