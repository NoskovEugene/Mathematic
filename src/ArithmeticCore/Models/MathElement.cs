namespace ArithmeticCore.Models;

public abstract class MathElement
{
    public int Index { get; set; }

    public abstract int Priority { get; }
    
    public abstract MathElementEnum ElementType { get; }

    public abstract override string ToString();
}