﻿// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Using Relational Patterns in Pattern Matching

// Relational patterns can be used to compare constant values using logical comparison
// operators such as <, >, <=, and >=

// Example: Given a Date, determine which quarter it occurs in 
string GetQuarterFromDate(DateTime date) => date.Month switch
{
    // TODO: Categorize the date into a quarter

    _ => throw new ArgumentOutOfRangeException(nameof(date), $"Unexpected month given: {date.Month}."),
};

// Console.WriteLine(GetQuarterFromDate(new DateTime(2028, 2, 14)));
// Console.WriteLine(GetQuarterFromDate(new DateTime(2028, 7, 19)));
// Console.WriteLine(GetQuarterFromDate(new DateTime(2028, 12, 25)));
// Console.WriteLine(GetQuarterFromDate(new DateTime(2028, 4, 1)));

// This also works with the regular "is" statement
void FirstOrSecondHalf(object dt) {
    // TODO: Categorize the date into a half

}
// FirstOrSecondHalf(new DateTime(2028, 7, 28));
// FirstOrSecondHalf(new DateTime(2028, 4, 1));
