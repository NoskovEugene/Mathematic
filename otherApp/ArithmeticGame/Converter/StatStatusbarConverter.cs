// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Converter.StatStatusbarConverter
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System;
using System.Globalization;
using System.Windows.Data;

namespace ArithmeticGame.Converter
{
  public class StatStatusbarConverter : IMultiValueConverter
  {
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
      string str = "";
      foreach (object obj in values)
        str += string.Format("{0} ", obj);
      return (object) str.Trim();
    }

    public object[] ConvertBack(
      object value,
      Type[] targetTypes,
      object parameter,
      CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
