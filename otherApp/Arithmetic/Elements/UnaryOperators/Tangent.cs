// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.UnaryOperators.Tangent
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System;

namespace Arithmetic.Elements.UnaryOperators
{
  public class Tangent : UnaryOperator
  {
    public override string Text => "TAN";

    public override object Clone() => (object) this.Clone<Tangent>();

    public override double Invoke(double value) => Math.Tan(value);

    public override string ToString() => this.ToStr();
  }
}
