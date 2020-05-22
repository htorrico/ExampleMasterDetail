using ExampleMasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExampleMasterDetail.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },               
                new HomeMenuItem {Id = MenuItemType.ButtonDemo, Title="Button Demo" },
                new HomeMenuItem {Id = MenuItemType.ButtonCode, Title="Button Code" },
                new HomeMenuItem {Id = MenuItemType.LabelDemo, Title="Label Demo" },
                new HomeMenuItem {Id = MenuItemType.LabelCode, Title="Label Code" },
                new HomeMenuItem {Id = MenuItemType.EntryDemo, Title="Entry Demo" },
                new HomeMenuItem {Id = MenuItemType.EntryCode, Title="Entry Code" },
                new HomeMenuItem {Id = MenuItemType.EditorDemo, Title="Editor Demo" },
                new HomeMenuItem {Id = MenuItemType.EditorCode, Title="Editor Code" },
                new HomeMenuItem {Id = MenuItemType.DatePickerDemo, Title="Datepicker Demo" }                
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}