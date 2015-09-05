using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;


namespace MenuManager.App
{
    public class JsonMenuItem : ObservableObject
    {
        private string _name;
        private string _icon;
        private string _command;
        private CommandParameters _commandParameters;

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

        public ObservableCollection<JsonMenuItem> Items { get; set; }
    }
}