// See https://aka.ms/new-console-template for more information
using SolutionTest;

Solution _solution = new Solution();
int lenght = 0;
int power;
Console.WriteLine("please enter the size tokens bag");
lenght = System.Convert.ToInt32(Console.ReadLine());
int[] tokens = new int[lenght];

Console.WriteLine("please enter the tokens value(power)");
for (int i = 0; i < lenght; i++)
    tokens[i] = System.Convert.ToInt32(Console.ReadLine());

Console.WriteLine("please enter the input power");
power = System.Convert.ToInt32(Console.ReadLine());
int output=_solution.BagOfTokensScore(tokens, power);
Console.WriteLine(output);