// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.Addition
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

namespace Arithmetic.Elements.Operators
{
  public class Addition : BinaryOperator
  {
    public override BinaryOperator Antonym => (BinaryOperator) new Substraction();

    public override string Text => "+";

    public Addition() => this.Priority = 1;

    public override object Clone() => (object) this.Clone<Addition>();

    public override string ToString() => this.Text;

    public override double Invoke(double left, double right) => left + right;
  }
}
