using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;


namespace MenuManager.App
{
    public class TabItemsMock : ObservableObject
    {
        public ObservableCollection<JsonMenuItem> Items { get; set; }
        public TabItemsMock()
        {
            Items = new ObservableCollection<JsonMenuItem>();
            Items.Add(new JsonMenuItem
            {
                Name = "Item 1",
                Items = new JsonMenuItemObservableCollection(new List<JsonMenuItem>
                {
                    new JsonMenuItem { Name = "Test 1" },
                    new JsonMenuItem { Name = "Test 2" },
                    new JsonMenuItem { Name = "Test 3" }
                })
            });
            Items.Add(new JsonMenuItem
            {
                Name = "Item 2",
                Items = new JsonMenuItemObservableCollection(new List<JsonMenuItem>
                {
                    new JsonMenuItem { Name = "Test 1" },
                    new JsonMenuItem { Name = "Test 2" }
                })
            });
        }
    }
}
