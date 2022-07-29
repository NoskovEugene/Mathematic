// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.Multiplication
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

namespace Arithmetic.Elements.Operators
{
  public class Multiplication : BinaryOperator
  {
    public override string Text => "*";

    public override BinaryOperator Antonym => (BinaryOperator) new Multiplication();

    public Multiplication() => this.Priority = 2;

    public override object Clone() => (object) this.Clone<Multiplication>();

    public override double Invoke(double left, double right) => left * right;

    public override string ToString() => this.Text;
  }
}
