// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Value
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System.Collections.Generic;

namespace Arithmetic.Elements
{
  public class Value : TreeElement
  {
    public double Result { get; set; }

    public Value() => this.Initialize();

    public Value(double value)
    {
      this.Initialize();
      this.Result = value;
    }

    private void Initialize()
    {
      this.Priority = 0;
      this.ElementType = ElementTypeEnum.Value;
    }

    public override object Clone()
    {
      Value obj = new Value();
      obj.Index = this.Index;
      obj.Result = this.Result;
      return (object) obj;
    }

    public override string ToString() => this.Result.ToString();

    public override List<TreeElement> ToElements() => new List<TreeElement>()
    {
      (TreeElement) this
    };
  }
}
