// Decompiled with JetBrains decompiler
// Type: Arithmetic.Extensions.TreeElementExtensions
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using Arithmetic.Elements;

namespace Arithmetic.Extensions
{
  public static class TreeElementExtensions
  {
    public static TOut Convert<TOut>(this TreeElement element) where TOut : TreeElement => (TOut) element;

    public static Value ConvertToValue(this Variable variable, double value)
    {
      Value obj = new Value(value);
      obj.Index = variable.Index;
      return obj;
    }

    public static bool TryCalc(this TreeElement element, out double result)
    {
      result = 0.0;
      if (element.ElementType == ElementTypeEnum.BinaryOperator || element.ElementType == ElementTypeEnum.UnaryOperator)
      {
        OperatorBase operatorBase = element.Convert<OperatorBase>();
        try
        {
          operatorBase.Calc();
        }
        catch
        {
          return false;
        }
        result = operatorBase.Result;
        return true;
      }
      result = 0.0;
      return false;
    }
  }
}
