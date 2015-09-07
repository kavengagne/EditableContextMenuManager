using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace MenuManager.App
{
    public class JsonMenuItemObservableCollection : ObservableCollection<JsonMenuItem>
    {
        public JsonMenuItemObservableCollection()
        {
        }

        public JsonMenuItemObservableCollection(List<JsonMenuItem> list) : base(list)
        {
        }

        private const int ItemHeight = 20;

        protected override void InsertItem(int index, JsonMenuItem item)
        {
            item.Top = Count * ItemHeight;
            base.InsertItem(index, item);
        }
    }
}