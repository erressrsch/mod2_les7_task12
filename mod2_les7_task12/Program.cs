namespace mod2_les7_task11
{
    enum Weekday
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of week day [1-7]: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine(Weekday.Monday);
                    break;

                case 2:
                    Console.WriteLine(Weekday.Tuesday);
                    break;

                case 3:
                    Console.WriteLine(Weekday.Wednesday);
                    break;

                case 4:
                    Console.WriteLine(Weekday.Thursday);
                    break;

                case 5:
                    Console.WriteLine(Weekday.Friday);
                    break;

                case 6:
                    Console.WriteLine(Weekday.Saturday);
                    break;

                case 7:
                    Console.WriteLine(Weekday.Sunday);
                    break;

            }
        }
    }
}