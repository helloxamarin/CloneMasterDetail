using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloneMasterDetail.Views;
using Xamarin.Forms;

namespace CloneMasterDetail.Views
{
	public class MainPage : TabbedPage
	{
		public MainPage ()
		{
		    Page itemsPage, aboutPage;

		    switch (Device.RuntimePlatform)
		    {
                case Device.iOS:
                    itemsPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };
                    itemsPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    itemsPage = new ItemsPage()
                    {
                        Title = "Browse"
                    };
                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };
                    break;
		    }

            Children.Add(itemsPage);
            Children.Add(aboutPage);

		    Title = Children[0].Title;
		}

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}