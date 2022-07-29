namespace ArithmeticCore.Models.Operators.Binary;

public class Multiplication : BinaryOperatorBase
{
    public override int Priority => 2;
    protected override string OperatorText => "*";
    protected override double InternalResolve(double left, double right)
    {
        return left * right;
    }
}