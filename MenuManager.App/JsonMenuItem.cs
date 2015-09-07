using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;


namespace MenuManager.App
{
    public class JsonMenuItem : ObservableObject
    {
        private string _name;
        private string _icon;
        private string _command;
        private CommandParameters _commandParameters;

        private int _top;
        private int _selectedItemIndex;
        private int _itemIndex;
        private JsonMenuItem _parentItem;
        
        private ICommand _addSubMenuCommand;
        private ICommand _deleteSubMenuCommand;


        public JsonMenuItem()
        {
            Icon = "";
            Command = "";
            CommandParameters = new CommandParameters();

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

        public int SelectedItemIndex
        {
            get { return _selectedItemIndex; }
            set
            {
                _selectedItemIndex = value;
                RaisePropertyChanged(() => SelectedItemIndex);
            }
        }

        public int ItemIndex
        {
            get { return _itemIndex; }
            set
            {
                _itemIndex = value;
                RaisePropertyChanged(() => ItemIndex);
            }
        }

        public JsonMenuItem ParentItem
        {
            get { return _parentItem; }
            set
            {
                _parentItem = value;
                RaisePropertyChanged(() => ParentItem);
            }
        }


        public ICommand AddSubMenuCommand => _addSubMenuCommand ?? (_addSubMenuCommand = new RelayCommand(AddSubMenu));

        public ICommand DeleteSubMenuCommand
            => _deleteSubMenuCommand ?? (_deleteSubMenuCommand = new RelayCommand(DeleteSubMenu));


        private void AddSubMenu()
        {
            if (ParentItem != null)
            {
                ParentItem.SelectedItemIndex = ItemIndex;
            }
            Items.Add(new JsonMenuItem
            {
                Name = "New Item",
                ParentItem = this
            });
        }

        private void DeleteSubMenu()
        {
            ParentItem?.DeleteItem(this);
        }

        private void DeleteItem(JsonMenuItem item)
        {
            Items.Remove(item);
        }
    }
}
