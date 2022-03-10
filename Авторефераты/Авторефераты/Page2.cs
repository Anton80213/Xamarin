using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Авторефераты
{
    public class Page2: ContentPage 
    {
        public Page2(Label header2, ListView listView)
        {
           Title = "Cтраница 2";
           Content = new StackLayout { Children = { header2, listView } };
           header2.HorizontalTextAlignment = TextAlignment.Center;
           header2.VerticalTextAlignment = TextAlignment.Center;
           header2.BackgroundColor = Color.GreenYellow;
           header2.TextColor = Color.Blue;
        }       
    }
}
