﻿using System;
using Xamarin.Forms;

namespace Sample.DrawerLayout
{
	public class DrawerBasicTest : ContentPage
	{
		public DrawerBasicTest()
		{
            Title = "Basic Test";
            Content = new Tizen.TV.UIControls.Forms.DrawerLayout()
            {
                DrawerClosedWidth = 60,
                Drawer = new StackLayout
                {
                    WidthRequest = 1000,
                    BackgroundColor = Color.Coral,
                    Children =
                    {
                        new Label
                        {
                            Text = "Drawer Area",
                            FontSize = 80,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                        }
                    }
                },
                Content = new StackLayout
                {
                    WidthRequest = 1800,
                    BackgroundColor = Color.Brown,
                    Children =
                    {
                        new Label() {
                            FontSize = 80,
                            Text = "Content Area",
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                    }
                }
            };
            var drawer = (Content as Tizen.TV.UIControls.Forms.DrawerLayout);
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                drawer.IsOpen = !drawer.IsOpen;
                return true;
            });
        }
	}
}