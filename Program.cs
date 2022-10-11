namespace CircleObjects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			int count = 0;
			double radius;
			
			bool goOn = true;
			while (goOn)
			{
				Console.Write("please enter a radius: ");
				try
				{
					radius = double.Parse(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("your input was not a valid number");
					continue;
				}
				count++;
				Circle circle = new Circle(radius);
				Console.WriteLine(circle.CalculateFormattedCircumference(radius) +" and "+ circle.CalculateFormattedArea(radius));
				goOn = AskToContinue();
			}
			Console.WriteLine("later. you made "+count+" circles");
		}
		public static bool AskToContinue()
		{
			Console.WriteLine("would you like to do another? (y/n)");
			string input = Console.ReadLine().ToLower();
			if (input == "y" || input == "yes")
			{
				return true;

			}
			else if (input == "n" || input == "no")
			{
				return false;
			}
			else
			{
				Console.WriteLine("try again (y/n)");
				return AskToContinue();
			}
		}
	}
}