// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.BinaryOperatorExtensions
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

namespace Arithmetic.Elements.Operators
{
  public static class BinaryOperatorExtensions
  {
    public static T Clone<T>(this BinaryOperator binary) where T : BinaryOperator, new()
    {
      T obj = new T();
      obj.Index = binary.Index;
      obj.Left = binary.Left;
      obj.Right = binary.Right;
      obj.Result = binary.Result;
      return obj;
    }
  }
}
