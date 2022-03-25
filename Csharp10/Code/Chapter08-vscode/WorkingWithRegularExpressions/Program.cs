﻿using static System.Console;
using System.Text.RegularExpressions;

Write("Enter your age: "); 
string? input = ReadLine();
Regex ageChecker = new(@"^\d$"); 
if (ageChecker.IsMatch(input))
{
  WriteLine("Thank you!");
}
else
{
  WriteLine($"This is not a valid age: {input}");
}


// Splitting a complex comma-separated string
string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
WriteLine($"Films to split: {films}");
string[] filmsDumb = films.Split(',');
WriteLine("Splitting with string.Split method:"); 
foreach (string film in filmsDumb)
{
  WriteLine(film);
}