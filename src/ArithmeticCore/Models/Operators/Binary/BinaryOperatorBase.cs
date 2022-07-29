using ArithmeticCore.Helpers;

namespace ArithmeticCore.Models.Operators.Binary;

public abstract class BinaryOperatorBase : MathElement
{
    public double ResolvedResult { get; protected set; } = double.NaN;

    protected abstract string OperatorText { get; }

    protected abstract double InternalResolve(double left, double right);

    public override MathElementEnum ElementType => MathElementEnum.BinaryOperation;

    public MathElement LeftOperand { get; set; }
    
    public MathElement RightOperand { get; set; }
    
    public void Resolve()
    {
        var left = ResolvingHelper.ResolveValue(LeftOperand);
        var right = ResolvingHelper.ResolveValue(RightOperand);
        ResolvedResult = InternalResolve(left, right);
    }
    

    public override string ToString()
    {
        return $"{LeftOperand} {OperatorText} {RightOperand}";
    }
}