namespace _5BasicConsoleOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, We'll demonstrate 5 simple console programs:!");
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            
            Console.WriteLine("1.\tProgram to Display 5 of my friend's names:");

            string[] friends = { "Ajinkya", "Vaishali", "Dhananjay", "Madhuri", "Prashant" };
            Console.WriteLine("My friends are:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            

            Console.WriteLine("2.\tCompute the square of sum and square of difference of two entered numbers.");

            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;

            Console.WriteLine($"Square of their sum: {sum * sum}");
            Console.WriteLine($"Square of their difference: {difference * difference}");
            
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            

            Console.WriteLine("3.\tDisplay a place you'd like to visit in both uppercase and lowercase.");

            Console.WriteLine("Enter the place you'd like to visit most:");
            string place = Console.ReadLine();
            Console.WriteLine(place.ToUpper());
            Console.WriteLine(place.ToLower());
            
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            

            Console.WriteLine("4.\tRead a number as a string and display it 10 times.");

            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            string result = "";

            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {
                    result += (input + ", ");
                }
                else
                {
                    result += (input );
                }
            }

            Console.WriteLine(result);
            
            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");


            Console.WriteLine("5.\tAnalyze the components of a full name.");

            Console.WriteLine("Please enter a full name:");
            string nameInput = Console.ReadLine();
            args = nameInput.Split(' ');

            Console.WriteLine($"There are {args.Length} parts in the name.");

            string fullName = string.Join(" ", args);
            Console.WriteLine($"Full name: {fullName}");

            Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");

        }
    }
}