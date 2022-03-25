using static System.Console;

// Branching with the if statement
string password = "ninja";
if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
  WriteLine("Your password is strong.");
}

// Pattern matching with the if statement
// add and remove the "" to change the behavior
object o = 3; 
int j = 4;
if (o is int i)
{
  WriteLine($"{i} x {j} = {i * j}");
}
else
{
  WriteLine("o is not an int so it cannot multiply!");
}


// Swicth statement
int number = (new Random()).Next(1, 7); 
WriteLine($"My random number is {number}");
switch (number)
{
  case 1: 
    WriteLine("One");
    break; // jumps to end of switch statement
  case 2:
    WriteLine("Two");
    goto case 1;
  case 3: // multiple case section
  case 4:
    WriteLine("Three or four");
    goto case 1;
  case 5:
    goto A_label;
  default:
    WriteLine("Default");
    break;
} // end of switch statement
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");


// While statement
int x = 0;
while (x < 10)
{
  WriteLine(x);
  x++;
}

// Do while statement
string? pass;
do
{
  Write("Enter your password: "); 
  pass = ReadLine();
}
while (pass != "Pa$$w0rd");
WriteLine("Correct!");


// For statement
for (int y = 1; y <= 10; y++)
{
  WriteLine(y);
}


// Foreach statement
string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
  WriteLine($"{name} has {name.Length} characters.");
}