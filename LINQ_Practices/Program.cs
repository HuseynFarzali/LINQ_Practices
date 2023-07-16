namespace LINQ_Practices
{
    internal class Program
    {
        static void Task1()
        {
            int[] array = RandomOps.GetRandomArray(lowerLimit: 0, UpperLimit: 20, size: 10);

            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            var filteredNumbers = from number in array
                                  where number % 2 == 0
                                  select number;

            foreach (var number in filteredNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void Task2()
        {
            int[] array = RandomOps.GetRandomArray(0, 100, 20);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var filtered = from number in array
                           where number > 20
                           where number < 70
                           select number;

            foreach (var item in filtered)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Task3()
        {
            int[] array = RandomOps.GetRandomArray(0, 20, 8);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var squaredPairs = from number in array
                               select new { Number = number, Square = Math.Pow(number, 2) };

            foreach (var item in squaredPairs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Task4()
        {
            int[] array = RandomOps.GetRandomArray(0, 10, 20);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var numberGroups =
                from number in array
                group number by number into numberGroup
                select new { Self = numberGroup.Key, Frequency = numberGroup.Count<int>() };

            foreach (var numberGroup in numberGroups)
            {
                Console.WriteLine($"Number {numberGroup.Self} appears {numberGroup.Frequency} time(s)");
            }
        }

        static void Task5()
        {
            Console.Write("Enter the string: ");
            string? sentence = Console.ReadLine();

            if (sentence == string.Empty || sentence == null)
                throw new ArgumentException("Given argument cannot be null or empty.");

            var charGroups = from character in sentence
                             group character by character into chGroups
                             select new { Self = chGroups.Key, Frequency = chGroups.Count<char>() };

            foreach (var group in charGroups)
            {
                Console.WriteLine($"Character '{group.Self}': {group.Frequency} time(s)");
            }
        }

        static void Task6()
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine((WeekDays)i);
            }
        }

        static void Task7()
        {
            int[] array = RandomOps.GetRandomArray(0, 10, 16);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var query =
                from number in array
                group number by number into numGroup
                select new { Self = numGroup.Key, Frequency = numGroup.Count<int>() };

            foreach (var group in query)
            {
                Console.WriteLine($"{group.Self} {group.Self * group.Frequency} {group.Frequency}");
            }
        }

        static void Task8()
        {
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.Write("Starting Character: ");
            char startChar = char.Parse(Console.ReadLine());
            startChar = startChar.ReturnUpper();

            Console.Write("Ending Character: ");
            char endChar = char.Parse(Console.ReadLine());
            endChar = endChar.ReturnUpper();

            var filteredCities = from city in cities
                                 where city.StartsWith(startChar)
                                 where city.EndsWith(endChar)
                                 select city;

            if (filteredCities.Any())
            {
                Console.WriteLine($"Cities starting with '{startChar}' and ending with '{endChar}':");
                foreach (var city in filteredCities)
                {
                    Console.Write(" " + city);
                }
            }

            else Console.WriteLine("No city found.");
        }

        static void Task9()
        {
            int[] array = RandomOps.GetRandomArray(0, 100, 8);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var filtered = from number in array
                           where number > 80
                           select number;

            Console.WriteLine("Numbers greater than 80:");
            foreach (var number in filtered)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void Task10()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            array.WriteInside<int>();

            Console.Write("Enter the threshold for comparison: ");
            int threshold = int.Parse(Console.ReadLine());

            var filteredArray = from number in array
                                where number > threshold
                                select number;

            Console.WriteLine($"Numbers greater then {threshold}:");
            foreach (var number in filteredArray)
            {
                Console.Write(number + " ");
            }
        }

        static void Task11()
        {
            int[] array = RandomOps.GetRandomArray(0, 20, 12);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var orderedArray = (from number in array
                               orderby number descending
                               select number).ToArray<int>();

            Console.Write("How many records do u want to display: ");
            int recordCount = int.Parse(Console.ReadLine());

            if (recordCount > array.Length) throw new ArgumentException("Record count cannot be larger than initial array size.");

            Console.WriteLine($"Top {recordCount} records:");
            for (int i = 0; i < recordCount; i++)
            {
                Console.Write(orderedArray[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Task11();
        }
    }
}