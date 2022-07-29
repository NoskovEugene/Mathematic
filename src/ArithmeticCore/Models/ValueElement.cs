using System.Globalization;

namespace ArithmeticCore.Models;

public class ValueElement : MathElement
{
    public double Value { get; set; }

    public override int Priority => 0;
    
    public override MathElementEnum ElementType => MathElementEnum.Value;
    
    public ValueElement()
    {
        
    }

    public ValueElement(double value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }
}