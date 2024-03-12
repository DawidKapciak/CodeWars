using System;
using System.Linq;

Console.WriteLine(Kata.ToCamelCase("the-stealth-warrior"));
Console.WriteLine(Kata.ToCamelCase("The_Stealth_Warrior"));
Console.WriteLine(Kata.ToCamelCase("The_Stealth-Warrior"));

public class Kata
{
    public static string ToCamelCase(string str)
    {
        var list = str.Split(new Char [] {'-' , '_' });
        var res = list[0];

        return list.Skip(1).Aggregate(res, (current, i) => current + string.Concat(i.First().ToString().ToUpper(), i.AsSpan(1)));
    }
}