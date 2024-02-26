namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("enter ammount one");
            var input = int.Parse(Console.ReadLine ()); 
               Console.WriteLine ("enter ammount Two");
            var inputTwo = int.Parse(Console.ReadLine ()); 
               
            var sum = Methods.Add(input,inputTwo);
            Console.WriteLine(sum);

            var a = 42.0m;
			var b = 69.0m;
			
			var decimalAnswer = Methods.Add(a,b);
			
			var boolAnswer = Methods.Add(0, 0, true);
			
			Console.WriteLine($"decimal add: {decimalAnswer}");
			Console.WriteLine(boolAnswer);
        }
    }
}
