// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.Division
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

namespace Arithmetic.Elements.Operators
{
  public class Division : BinaryOperator
  {
    public Division() => this.Priority = 2;

    public override string Text => "/";

    public override BinaryOperator Antonym => (BinaryOperator) new Multiplication();

    public override object Clone() => (object) this.Clone<Division>();

    public override double Invoke(double left, double right) => left / right;

    public override string ToString() => "/";
  }
}
