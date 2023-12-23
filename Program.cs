//We want to make a program that takes a word in, finds a target letter and tells us how many times that
//letter appears in the word, or if it appears at all.
using CountLetters;

string input = InputManager.GetUserInput("Please input the word you would like to check.");
char target = InputManager.GetTarget();

CheckLetters checkLetters = new CheckLetters(input, target);

int count = checkLetters.GetCount();

Console.WriteLine($"The number of {target}'s in {input} is {count}");

 



