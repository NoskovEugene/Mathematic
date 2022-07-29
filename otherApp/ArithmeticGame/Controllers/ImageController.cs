// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Controllers.ImageController
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System;

namespace ArithmeticGame.Controllers
{
  public class ImageController
  {
    protected Random Random { get; set; }

    public ImageController(Random random) => this.Random = random;

    public (string image1, string image2) GetRandom(bool lose)
    {
      if (lose)
      {
        (int gen1, int gen2) = this.GetRandom(1, 19);
        return (string.Format("/Content/Lose/{0}.png", (object) gen1), string.Format("/Content/Lose/{0}.png", (object) gen2));
      }
      (int gen1_1, int gen2_1) = this.GetRandom(1, 16);
      return (string.Format("/Content/Win/{0}.png", (object) gen1_1), string.Format("/Content/Win/{0}.png", (object) gen2_1));
    }

    private (int gen1, int gen2) GetRandom(int min, int max)
    {
      int num1 = this.Random.Next(min, max);
      int num2 = this.Random.Next(min, max);
      while (num1 == num2)
        num2 = this.Random.Next(1, 19);
      return (num1, num2);
    }
  }
}
