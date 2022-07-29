// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.Exponent
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System;

namespace Arithmetic.Elements.Operators
{
  public class Exponent : BinaryOperator
  {
    public override string Text => "^";

    public override BinaryOperator Antonym => (BinaryOperator) null;

    public Exponent() => this.Priority = 3;

    public override object Clone() => (object) this.Clone<Exponent>();

    public override double Invoke(double left, double right) => Math.Pow(left, right);

    public override string ToString() => this.Text;
  }
}
