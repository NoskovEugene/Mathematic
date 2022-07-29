// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Converter.BoolToVisibilityConverter
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ArithmeticGame.Converter
{
  public class BoolToVisibilityConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (bool) value ? (object) Visibility.Visible : (object) Visibility.Hidden;

    public object ConvertBack(
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
