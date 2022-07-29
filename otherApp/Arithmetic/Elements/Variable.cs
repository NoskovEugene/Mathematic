// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Variable
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System.Collections.Generic;

namespace Arithmetic.Elements
{
  public class Variable : TreeElement
  {
    public string Name { get; set; }

    public bool NeedCalc { get; set; }

    public bool Int { get; set; }

    public bool Synced { get; set; }

    public Variable()
    {
      this.Priority = 0;
      this.NeedCalc = false;
      this.Int = false;
      this.ElementType = ElementTypeEnum.Variable;
    }

    public override object Clone()
    {
      Variable variable = new Variable();
      variable.Index = this.Index;
      variable.Name = this.Name;
      variable.NeedCalc = this.NeedCalc;
      variable.Int = this.Int;
      variable.Synced = this.Synced;
      return (object) variable;
    }

    public override string ToString() => this.Name;

    public override List<TreeElement> ToElements() => new List<TreeElement>()
    {
      (TreeElement) this
    };
  }
}
