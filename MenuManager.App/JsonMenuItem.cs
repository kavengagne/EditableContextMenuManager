using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using GalaSoft.MvvmLight;


namespace MenuManager.App
{
    public class JsonMenuItem : ObservableObject
    {
        private string _name;
        private string _icon;
        private string _command;
        private CommandParameters _commandParameters;
        private int _top;


        public JsonMenuItem()
        {
            Items = new JsonMenuItemObservableCollection();
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public string Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                RaisePropertyChanged(() => Icon);
            }
        }

        public string Command
        {
            get { return _command; }
            set
            {
                _command = value;
                RaisePropertyChanged(() => Command);
            }
        }

        public CommandParameters CommandParameters
        {
            get { return _commandParameters; }
            set
            {
                _commandParameters = value;
                RaisePropertyChanged(() => CommandParameters);
            }
        }

        public JsonMenuItemObservableCollection Items { get; set; }

        public int Top
        {
            get { return _top; }
            set
            {
                _top = value;
                RaisePropertyChanged(() => Top);
            }
        }
    }


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