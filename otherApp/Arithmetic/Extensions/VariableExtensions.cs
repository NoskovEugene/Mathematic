// Decompiled with JetBrains decompiler
// Type: Arithmetic.Extensions.VariableExtensions
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using Arithmetic.Elements;

namespace Arithmetic.Extensions
{
  public static class VariableExtensions
  {
    private const string EngWords = "abcdefghijklmnopqrstuvwxyz";

    public static Variable Sync(this Variable variable, int index)
    {
      variable.SetNameByIndex(index);
      variable.Synced = true;
      return variable;
    }

    public static Variable SetNameByIndex(this Variable variable, int index)
    {
      variable.Name = VariableExtensions.GetNextName(index);
      return variable;
    }

    private static string GetNextName(int count)
    {
      int length = "abcdefghijklmnopqrstuvwxyz".Length;
      int num = count / length;
      return string.Format("{0}{1}", (object) "abcdefghijklmnopqrstuvwxyz".Substring(count % length, 1), (object) num);
    }
  }
}
