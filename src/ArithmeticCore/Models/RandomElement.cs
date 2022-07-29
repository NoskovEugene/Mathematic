namespace ArithmeticCore.Models;

public class RandomElement : MathElement
{
    public RandomElement(int leftBound, int rightBound)
    {
        LeftBound = leftBound;
        RightBound = rightBound;
    }

    public override int Priority => 0;
    
    public override MathElementEnum ElementType => MathElementEnum.Random;
    
    public int LeftBound { get; }
    
    public int RightBound { get; set; }

    public ValueElement ComputeValueElement()
    {
        return new ValueElement(Random.Shared.Next(LeftBound, RightBound));
    }
    
    public override string ToString()
    {
        return $"[{LeftBound}??{RightBound}]";
    }
}