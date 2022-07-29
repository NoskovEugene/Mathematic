// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.BinaryOperator
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System;
using System.Collections.Generic;

namespace Arithmetic.Elements.Operators
{
  public abstract class BinaryOperator : OperatorBase
  {
    public override double Result { get; set; }

    public TreeElement Left { get; set; }

    public TreeElement Right { get; set; }

    public abstract double Invoke(double left, double right);

    public abstract string Text { get; }

    public abstract BinaryOperator Antonym { get; }

    public override void Calc()
    {
      if (!Actions.Action.ContainsKey(this.Left.ElementType))
        throw new Exception("Unable type for left element");
      double left = Actions.Action[this.Left.ElementType](this.Left);
      if (!Actions.Action.ContainsKey(this.Right.ElementType))
        throw new Exception("Unable type for left element");
      double right = Actions.Action[this.Right.ElementType](this.Right);
      this.Result = this.Invoke(left, right);
    }

    public BinaryOperator() => this.ElementType = ElementTypeEnum.BinaryOperator;

    public override List<TreeElement> ToElements()
    {
      List<TreeElement> elements = this.Left.ToElements();
      elements.Add((TreeElement) this);
      elements.AddRange((IEnumerable<TreeElement>) this.Right.ToElements());
      return elements;
    }
  }
}
