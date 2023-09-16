// See https://aka.ms/new-console-template for more information
using DelegatesInCSharp;

Console.WriteLine("Example of Built-in Delegates");
Console.WriteLine("==============================");

Console.WriteLine("Example of Action Delegate");
ActionDelegate.TestActionDelegate();

Console.WriteLine("Example of Func Delegate");
FuncDelegate.TestFuncDelegate();


Console.WriteLine("Example of Predicate Delegate");
PredicateDelegate.TestPredicateDelegate();

Console.ReadLine();
