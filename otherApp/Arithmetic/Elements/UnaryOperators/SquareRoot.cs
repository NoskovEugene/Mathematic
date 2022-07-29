// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.UnaryOperators.SquareRoot
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System;

namespace Arithmetic.Elements.UnaryOperators
{
  public class SquareRoot : UnaryOperator
  {
    public override string Text => "SQRT";

    public override object Clone() => (object) this.Clone<SquareRoot>();

    public override double Invoke(double value) => Math.Sqrt(value);

    public override string ToString() => this.ToStr();
  }
}
