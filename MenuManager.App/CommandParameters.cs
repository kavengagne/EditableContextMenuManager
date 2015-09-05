using GalaSoft.MvvmLight;


namespace MenuManager.App
{
    public class CommandParameters : ObservableObject
    {
        private string _separator;
        private string _verb;

        public string Separator
        {
            get { return _separator; }
            set
            {
                _separator = value;
                RaisePropertyChanged(() => Separator);
            }
        }

        public string Verb
        {
            get { return _verb; }
            set
            {
                _verb = value;
                RaisePropertyChanged(() => Verb);
            }
        }
    }
}