using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ExampleMasterDetail.Models;

namespace ExampleMasterDetail.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;                    
                    case (int)MenuItemType.ButtonDemo:
                        MenuPages.Add(id, new NavigationPage(new ButtonDemo()));
                        break;
                    case (int)MenuItemType.ButtonCode:
                        MenuPages.Add(id, new NavigationPage(new ButtonCode()));
                        break;
                    case (int)MenuItemType.DatePickerDemo:
                        MenuPages.Add(id, new NavigationPage(new DatePickerDemo()));
                        break;
                    case (int)MenuItemType.LabelDemo:
                        MenuPages.Add(id, new NavigationPage(new LabelDemo()));
                        break;
                    case (int)MenuItemType.LabelCode:
                        MenuPages.Add(id, new NavigationPage(new LabelCode()));
                        break;
                    case (int)MenuItemType.EditorDemo:
                        MenuPages.Add(id, new NavigationPage(new EditorDemo()));
                        break;
                    case (int)MenuItemType.EditorCode:
                        MenuPages.Add(id, new NavigationPage(new EditorCode()));
                        break;
                    case (int)MenuItemType.EntryDemo:
                        MenuPages.Add(id, new NavigationPage(new EntryDemo()));
                        break;
                    case (int)MenuItemType.EntryCode:
                        MenuPages.Add(id, new NavigationPage(new EntryCode()));                                            
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}