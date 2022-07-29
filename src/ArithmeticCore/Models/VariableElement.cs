namespace ArithmeticCore.Models;

public class VariableElement : MathElement
{
    public VariableElement(string variableName)
    {
        VariableName = variableName;
    }

    public override int Priority => 0;

    public string VariableName { get; set; }

    public double Value { get; set; } = double.NaN;
    
    public override MathElementEnum ElementType => MathElementEnum.Variable;

    public override string ToString() => VariableName;
}