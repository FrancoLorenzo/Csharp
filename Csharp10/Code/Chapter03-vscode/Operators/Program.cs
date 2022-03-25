using static System.Console;

// Exploring unary operators
int a = 3;
int b = a++;

WriteLine($"a is {a}, b is {b}");

int c = 3;
int d = ++c;

WriteLine($"a is {c}, b is {d}");

// Exploring binary arithmetic operators
int e = 11; 
int f = 3;
WriteLine($"e is {e}, f is {f}"); 
WriteLine($"e + f = {e + f}"); 
WriteLine($"e - f = {e - f}"); 
WriteLine($"e * f = {e * f}"); 
WriteLine($"e / f = {e / f}"); 
WriteLine($"e % f = {e % f}");


// Assignment operators
int p = 6;
p += 3; // equivalent to p = p + 3;
p -= 3; // equivalent to p = p - 3;
p *= 3; // equivalent to p = p * 3;
p /= 3; // equivalent to p = p / 3;