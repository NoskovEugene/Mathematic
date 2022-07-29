// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.MainWindow
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using ArithmeticGame.Extensions;
using ArithmeticGame.ViewModels;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace ArithmeticGame
{
  public partial class MainWindow : Window, IComponentConnector
  {
    public Dictionary<Key, Action<MainViewModel>> Actions = new Dictionary<Key, Action<MainViewModel>>()
    {
      {
        Key.D1,
        (Action<MainViewModel>) (x => x.OnNumberClick("1"))
      },
      {
        Key.NumPad1,
        (Action<MainViewModel>) (x => x.OnNumberClick("1"))
      },
      {
        Key.D2,
        (Action<MainViewModel>) (x => x.OnNumberClick("2"))
      },
      {
        Key.NumPad2,
        (Action<MainViewModel>) (x => x.OnNumberClick("2"))
      },
      {
        Key.D3,
        (Action<MainViewModel>) (x => x.OnNumberClick("3"))
      },
      {
        Key.NumPad3,
        (Action<MainViewModel>) (x => x.OnNumberClick("3"))
      },
      {
        Key.D4,
        (Action<MainViewModel>) (x => x.OnNumberClick("4"))
      },
      {
        Key.NumPad4,
        (Action<MainViewModel>) (x => x.OnNumberClick("4"))
      },
      {
        Key.D5,
        (Action<MainViewModel>) (x => x.OnNumberClick("5"))
      },
      {
        Key.NumPad5,
        (Action<MainViewModel>) (x => x.OnNumberClick("5"))
      },
      {
        Key.D6,
        (Action<MainViewModel>) (x => x.OnNumberClick("6"))
      },
      {
        Key.NumPad6,
        (Action<MainViewModel>) (x => x.OnNumberClick("6"))
      },
      {
        Key.D7,
        (Action<MainViewModel>) (x => x.OnNumberClick("7"))
      },
      {
        Key.NumPad7,
        (Action<MainViewModel>) (x => x.OnNumberClick("7"))
      },
      {
        Key.D8,
        (Action<MainViewModel>) (x => x.OnNumberClick("8"))
      },
      {
        Key.NumPad8,
        (Action<MainViewModel>) (x => x.OnNumberClick("8"))
      },
      {
        Key.D9,
        (Action<MainViewModel>) (x => x.OnNumberClick("9"))
      },
      {
        Key.NumPad9,
        (Action<MainViewModel>) (x => x.OnNumberClick("9"))
      },
      {
        Key.D0,
        (Action<MainViewModel>) (x => x.OnNumberClick("0"))
      },
      {
        Key.NumPad0,
        (Action<MainViewModel>) (x => x.OnNumberClick("0"))
      },
      {
        Key.Return,
        (Action<MainViewModel>) (x => x.Submit())
      },
      {
        Key.Back,
        (Action<MainViewModel>) (x => x.OnDeleteClick())
      }
    };
    internal Button Zero;
    internal Button One;
    internal Button Two;
    internal Button Three;
    internal Button Four;
    internal Button Five;
    internal Button Six;
    internal Button Seven;
    internal Button Eight;
    internal Button Nine;
    private bool _contentLoaded;

    public MainWindow(MainViewModel viewModel)
    {
      this.DataContext = (object) viewModel;
      this.InitializeComponent();
      this.KeyDown += new KeyEventHandler(this.MainWindow_KeyDown);
    }

    private void MainWindow_KeyDown(object sender, KeyEventArgs e)
    {
      if (!this.Actions.ContainsKey(e.Key))
        return;
      this.Actions[e.Key](this.Context<MainViewModel>());
    }

    private void Help_Click(object sender, RoutedEventArgs e)
    {
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/ArithmeticGame;component/mainwindow.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.Zero = (Button) target;
          break;
        case 2:
          this.One = (Button) target;
          break;
        case 3:
          this.Two = (Button) target;
          break;
        case 4:
          this.Three = (Button) target;
          break;
        case 5:
          this.Four = (Button) target;
          break;
        case 6:
          this.Five = (Button) target;
          break;
        case 7:
          this.Six = (Button) target;
          break;
        case 8:
          this.Seven = (Button) target;
          break;
        case 9:
          this.Eight = (Button) target;
          break;
        case 10:
          this.Nine = (Button) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
