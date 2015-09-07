using System.Collections.Specialized;
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

        private ICommand _addSubMenuCommand;


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

        public ICommand AddSubMenuCommand => _addSubMenuCommand ?? (_addSubMenuCommand = new RelayCommand(AddSubMenu));


        private void AddSubMenu()
        {
            Items.Add(new JsonMenuItem
            {
                Name = "New Item"
            });
        }
    }
}
