using System;
using System.Collections.Generic;
using System.Text;

namespace practice_csharp_feature
{
    public class EnumPractice
    {
        public enum DayofWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public enum fruits
        {
            Mango = 1,
            Licchi,
            Jackfruits,
            Banana,
            Guava,
            Oranges,
            Pineapple,
            Strawberries
        }

        public enum studentCondition
        {
            Normal = 0,
            Excerllent = 1,
            Bad = 0,
            good = 2
        }
        public void EnumFunctionality()
        {

            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Monday, DayofWeek.Monday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Tuesday, DayofWeek.Tuesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Wednesday, DayofWeek.Wednesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Thursday, DayofWeek.Thursday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Friday, DayofWeek.Friday);
            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Saturday, DayofWeek.Saturday);

            Console.WriteLine("name of the fruits");

            Console.WriteLine("fruit {0} {1}", (int)fruits.Mango, fruits.Mango);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Licchi, fruits.Licchi);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Jackfruits, fruits.Jackfruits);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Banana, fruits.Banana);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Guava, fruits.Guava);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Oranges, fruits.Oranges);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Pineapple, fruits.Pineapple);
            Console.WriteLine("fruit {0} {1}", (int)fruits.Strawberries, fruits.Strawberries);


            Console.WriteLine("we can have the same value in the enum type");

            Console.WriteLine("student status {0} {1}", (int)studentCondition.Normal, studentCondition.Normal);
            Console.WriteLine("student status {0} {1}", (int)studentCondition.Bad, studentCondition.Bad);
            Console.WriteLine("student status {0} {1}", (int)studentCondition.good, studentCondition.good);
            Console.WriteLine("student status {0} {1}", (int)studentCondition.Excerllent, studentCondition.Excerllent);

            Console.WriteLine("we can have the same value in the enum type");

            string[] studentConditionNameList = Enum.GetNames(typeof(studentCondition));

            Console.WriteLine("Name of the enum items");

            foreach (var name in studentConditionNameList)
            {
                Console.WriteLine(name);
            }

            int[] values = (int[])Enum.GetValues(typeof(studentCondition));

            Console.WriteLine("Value of the enum items");

            foreach (var val in values)
            {
                Console.WriteLine(val);
            }

        }
    }
}
