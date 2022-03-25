using static System.Console;

// Making a value type nullable
// int thisCannotBeNull  = 4; 
// thisCannotBeNull = null; // compile error!
int? thisCouldBeNull = null; 
WriteLine(thisCouldBeNull); 
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7; 
WriteLine(thisCouldBeNull); 
WriteLine(thisCouldBeNull.GetValueOrDefault());
