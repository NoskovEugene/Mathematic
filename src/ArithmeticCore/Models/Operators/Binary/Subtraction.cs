namespace ArithmeticCore.Models.Operators.Binary;

public class Subtraction : BinaryOperatorBase
{
    public override int Priority => 1;

    protected override string OperatorText => "-";
    
    protected override double InternalResolve(double left, double right)
    {
        return left - right;
    }
}