// See https://aka.ms/new-console-template for more information
using RoundTheCode.CSharp11.Features;

var requiredMember = new RequiredMember("Dave");

var listPattern = new ListPatterns();
Console.WriteLine($"Is1_3_5 = {listPattern.Is_1_3_5(new int[] { 1, 3, 5 })}");
Console.WriteLine($"Is1___5 = {listPattern.Is_1___5(new int[] { 1, 9, 5 })}");
Console.WriteLine($"Is_1_DotDot_5 = {listPattern.Is_1_DotDot_5(new int[] { 1, 9, 3, 8, 5 })}");
Console.WriteLine($"Is_1_Over_5 = {listPattern.Is_1_Over_5(new int[] { 1, 9, 3, 8, 6 })}");

