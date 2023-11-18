internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length > 2)
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[2]);
            int result = new int();
            switch (args[1])
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error! Divide by zero!");
                    break;
                case "*":
                    result = num1 * num2;
                    break;
            }
            Console.WriteLine($"{num1} {args[1]} {num2} = {result}");
        }
        else
            Console.WriteLine("Not enough args!");
    }
}