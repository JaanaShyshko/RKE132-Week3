﻿int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 - 6

switch (weekDay) // väärtus, mida kontrollitakse
{
    case 0: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Sunday");
        break;
    case 1: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Monday");
        break;
    case 2: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Thursday");
        break;
    case 3: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Wednesday");
        break;
    case 4: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Thursday");
        break;
    case 5: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Friday");
        break;
    case 6: //case 0: == if(weekday == 0)
        Console.WriteLine("It's Saturday");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken.");
        break;
}

Console.WriteLine("Have a nice day!");
