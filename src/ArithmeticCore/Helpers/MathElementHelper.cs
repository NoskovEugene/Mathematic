using ArithmeticCore.Models;

namespace ArithmeticCore.Helpers;

public static class MathElementHelper
{
    private const string EnglishWords = "abcdefghijklmnopqrstuvwxyz";
    
    public static T As<T>(this MathElement value)
        where T: MathElement
    {
        return (T)value;
    }
}