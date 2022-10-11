using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
	internal class Circle
	{
		public Circle(double radius)
		{

		}
		public double CalculateCircumference(double radius)
		{
			return radius * Math.PI * 2;
		}
		public string CalculateFormattedCircumference(double radius)
		{
			return "the circumference of your circle is: "+ FormatNumber(CalculateCircumference(radius));
		}
		public double CalculateArea(double radius)
		{
			return Math.PI * (radius * radius);
		}
		public string CalculateFormattedArea(double radius)
		{
			return "the area of your circle is: " + FormatNumber(CalculateArea(radius));
		}
		public string FormatNumber(double x)
		{
			return Math.Round(x, 2)+"";
		}
	}
}
