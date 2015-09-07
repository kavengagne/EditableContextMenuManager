using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace MenuManager.App
{
    public class JsonMenuItemObservableCollection : ObservableCollection<JsonMenuItem>
    {
        private const int ItemHeight = 20;


        public JsonMenuItemObservableCollection()
        {
        }

        public JsonMenuItemObservableCollection(List<JsonMenuItem> list) : base(list)
        {
        }


        protected override void InsertItem(int index, JsonMenuItem item)
        {
            item.ItemIndex = index;
            item.Top = Count * ItemHeight;
            base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            for (int i = index; i < Count; i++)
            {
                this[i].ItemIndex -= 1;
                this[i].Top -= ItemHeight;
            }
        }
    }
}