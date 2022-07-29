// See https://aka.ms/new-console-template for more information

using ArithmeticCore;
using ArithmeticCore.Helpers;
using ArithmeticCore.Models.Operators.Binary;

var math = new Mathematics();
math.Random(1, 10).Plus().Random(1,10);
for (int i = 0; i < 10; i++)
{
    var tree = math.ResolveTree().As<BinaryOperatorBase>();
    tree.Resolve();
    Console.WriteLine($"Iteration {i}) {tree.ToString()} = {tree.ResolvedResult}");
}
Console.ReadKey();

