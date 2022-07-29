// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Converter.EquationConverter
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System;
using System.Globalization;
using System.Windows.Data;

namespace ArithmeticGame.Converter
{
  public class EquationConverter : IMultiValueConverter
  {
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
      string str = "";
      foreach (object obj in values)
        str += obj?.ToString();
      return (object) str;
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
