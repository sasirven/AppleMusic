using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleMusic.Views.Pages;

public partial class DetailPage : ContentPage
{
    public DetailPage()
    {
        InitializeComponent();
        List.ItemsSource = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    }
}