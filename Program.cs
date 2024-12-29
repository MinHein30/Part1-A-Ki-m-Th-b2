// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Enter machine-calculated value for Pi: ");
double pi_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for sin(x): ");
double sin_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for ln(1 + x): ");
double ln_machine = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter machine-calculated value for cos(x): ");
double cos_machine = Convert.ToDouble(Console.ReadLine());


Console.Write("\nEnter manually calculated value for Pi: ");
double pi_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for sin(x): ");
double sin_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for ln(1 + x): ");
double ln_manual = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter manually calculated value for cos(x): ");
double cos_manual = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\n Metric   |  Machine Value      |  Manual Value       | Status   ");
Console.WriteLine($"----------+---------------------+---------------------+----------");

Console.WriteLine($" Pi       | {pi_machine,-19} | {pi_manual,-19} | {(pi_machine == pi_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" sin(x)   | {sin_machine,-19} | {sin_manual,-19} | {(sin_machine == sin_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" ln(1+x)  | {ln_machine,-19} | {ln_manual,-19} | {(ln_machine == ln_manual ? "Passed" : "Failed"),-8} ");
Console.WriteLine($" cos(x)   | {cos_machine,-19} | {cos_manual,-19} | {(cos_machine == cos_manual ? "Passed" : "Failed"),-8} ");

Console.WriteLine();
Console.ReadKey();