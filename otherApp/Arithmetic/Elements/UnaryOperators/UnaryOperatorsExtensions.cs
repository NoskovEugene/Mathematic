// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.UnaryOperators.UnaryOperatorsExtensions
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System.Collections.Generic;

namespace Arithmetic.Elements.UnaryOperators
{
  public static class UnaryOperatorsExtensions
  {
    public static T Clone<T>(this UnaryOperator unaryOperator) where T : UnaryOperator, new()
    {
      T obj = new T();
      obj.Payload = unaryOperator.Payload;
      obj.Index = unaryOperator.Index;
      obj.Root = unaryOperator.Root;
      obj.NeedPrepare = unaryOperator.NeedPrepare;
      obj.Result = unaryOperator.Result;
      return obj;
    }

    public static string ToStr(this UnaryOperator unary) => unary.Text + "(" + string.Join<TreeElement>("", (IEnumerable<TreeElement>) unary.Payload) + ")";
  }
}
