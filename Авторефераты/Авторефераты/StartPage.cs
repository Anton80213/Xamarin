using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Авторефераты
{
    public partial class StartPage: ContentPage
    {
        public StartPage()
	    {
	            Title = "Главная страница";
	            Label header = new Label()
                {
                    Text = "Добро пожаловать в каталог авторефератов библиотеки АГУ!",
                };
                header.HorizontalTextAlignment = TextAlignment.Center;
                header.VerticalTextAlignment = TextAlignment.Center;
                header.BackgroundColor = Color.GreenYellow;
                header.TextColor = Color.Blue;
                Button nextButton = new Button
	            {
	                Text = "Вперед",
	                HorizontalOptions = LayoutOptions.Center,
	                VerticalOptions = LayoutOptions.Center
	            };
                nextButton.BackgroundColor = Color.Gold;
	            nextButton.Clicked += OnButtonClicked;
	            Content = new StackLayout { Children = { header, nextButton} };
        }
        private async void OnButtonClicked(object sender, EventArgs e)
	    {
	            await Navigation.PushAsync(new Page1());
	    }

    }
}
