using ArithmeticCore.Models;
using ArithmeticCore.Models.Operators.Binary;

namespace ArithmeticCore.Helpers;

public static class MathematicsHelper
{
    public static Mathematics Plus(this Mathematics mathematics)
    {
        mathematics.AddElement(new Addition());
        return mathematics;
    }
    
    public static Mathematics Minus(this Mathematics mathematics)
    {
        mathematics.AddElement(new Subtraction());
        return mathematics;
    }
    
    public static Mathematics Div(this Mathematics mathematics)
    {
        mathematics.AddElement(new Division());
        return mathematics;
    }
    
    public static Mathematics Multiply(this Mathematics mathematics)
    {
        mathematics.AddElement(new Multiplication());
        return mathematics;
    }

    public static Mathematics Random(this Mathematics mathematics, int left, int right)
    {
        mathematics.AddElement(new RandomElement(left, right));
        
        return mathematics;
    }
}