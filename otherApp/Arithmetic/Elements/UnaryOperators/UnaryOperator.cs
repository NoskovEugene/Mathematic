// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.UnaryOperators.UnaryOperator
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System;
using System.Collections.Generic;

namespace Arithmetic.Elements.UnaryOperators
{
  public abstract class UnaryOperator : OperatorBase
  {
    public List<TreeElement> Payload { get; set; }

    public TreeElement Root { get; set; }

    public bool NeedPrepare { get; set; } = true;

    public override double Result { get; set; }

    public abstract string Text { get; }

    public abstract double Invoke(double value);

    public override void Calc()
    {
      double num = 0.0;
      if (!this.NeedPrepare && this.Root != null)
      {
        if (!Actions.Action.ContainsKey(this.Root.ElementType))
          throw new Exception("Unable type for element");
        num = Actions.Action[this.Root.ElementType](this.Root);
      }
      this.Result = this.Invoke(num);
    }

    public override List<TreeElement> ToElements() => this.Root.ToElements();

    public UnaryOperator() => this.ElementType = ElementTypeEnum.UnaryOperator;
  }
}
