using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridTutorial {
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage {
    public MainPage() {
      InitializeComponent();
    }

    void onEditorTextChanged(Object sender, TextChangedEventArgs e) {
      string oldText = e.OldTextValue;
      string newText = e.NewTextValue;
    }

    void onEditorTextCompleted(Object sender, EventArgs e) {
      string text = ((Editor)sender).Text;
      _ = text.Length > 9 ? MyLabel1.Text = "Changed to: " + text.Substring(0, 10) + " ..." : MyLabel1.Text = "Editor Changed ...";
    }

    void onTextChanged(Object sender, TextChangedEventArgs e) {
      string oldText = e.OldTextValue;
      string newText = e.NewTextValue;
    }

    void onTextCompleted(Object sender, EventArgs e) {
      string text = ((Entry)sender).Text;
    }

    void onButtonClicked(Object sender, EventArgs e) {
      var btn = (sender as Button);
      _ = btn.Text == "Click me baby one more time!" ? btn.Text = "OKAY, YOU CAN STOP NOW!" : btn.Text = "Click me baby one more time!";
    }
  }
}
