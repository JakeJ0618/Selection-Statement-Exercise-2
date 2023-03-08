namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your favorite school subject");
            var answer = Console.ReadLine();
            
            switch (answer)
            {
                case "math":
                    {
                        Console.WriteLine("Math was my favorite too!");
                        break;
                    }
                case "science":
                    {
                        Console.WriteLine("Science was a lot of fun in school!");
                        break;
                    }
                case "history":
                    {
                        Console.WriteLine("History is always incredibly interesting!");
                        break;
                    }
                case "english":
                    {
                        Console.WriteLine("seriously? that's your favorite?");
                        break;
                    }
                case "athletics":
                    {
                        Console.WriteLine("Ohhhh, you're one of those kids. Just kidding, I liked that too!");
                        break;
                    }
                case "default":
                    {
                        Console.WriteLine("I don't know what that class is.");
                        break;
                    }

                    
            }
                   
        }
    }
}