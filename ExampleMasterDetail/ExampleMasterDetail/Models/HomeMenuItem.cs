using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleMasterDetail.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Example,
        Example2
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
