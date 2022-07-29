using ArithmeticCore.Models;
using ArithmeticCore.Models.Operators.Binary;

namespace ArithmeticCore.Helpers;

public static class ResolvingHelper
{
    public static readonly Dictionary<MathElementEnum, Func<MathElement, double>> ResolvingRules = new()
    {
        {
            MathElementEnum.Value,
            e=> e.As<ValueElement>().Value
        },
        {
            MathElementEnum.BinaryOperation,
            e =>
            {
                var element = e.As<BinaryOperatorBase>();
                element.Resolve();
                return element.ResolvedResult;
            }
        },
        {
            MathElementEnum.Variable, _ => throw new Exception("Variable can't be convert to value")
        }
    };
    
    public static double ResolveValue(MathElement element)
    {
        return ResolvingRules[element.ElementType](element);
    }
}