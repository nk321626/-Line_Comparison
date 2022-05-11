// See https://aka.ms/new-console-template for more information
using Line_Comparison;

Console.WriteLine("Welcome to Line Comparison Computation Program");
LineComparison lineComparison = new LineComparison();
lineComparison.LineLength();
//lineComparison.CheckEquality();
lineComparison.CompareTwoLines(); //Call The Methods
Console.ReadLine();