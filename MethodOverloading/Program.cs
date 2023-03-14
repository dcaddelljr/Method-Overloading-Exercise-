namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Add(2, 4);
            Console.WriteLine(result);
            //Console.WriteLine(Add(2, 4));
            var deciResult = Add(4.2m, 6.7m);
            Console.WriteLine($"Decimal: {deciResult}");
            //Console.WriteLine(Add(6.6, 8.4));

            Console.WriteLine(Add(-1, 0, true));
            Console.WriteLine($"should print 5.37 dollars: {Add(2, 3.37m, true)}");
        }   

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2) //can use double instead of decimal if no need for preciseness
        {
            return num1 + num2;
        }
        public static string Add(decimal num1, decimal num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            //else if (isTrue == true && sum < 1)
            //{
            //    return $"{sum} dollars";
            //}
            else
            {
                return sum.ToString();
            }
        }
    }
}
