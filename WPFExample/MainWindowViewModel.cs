using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFExample
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ObservableCollection<PersonViewModel> _People;

        public ObservableCollection<PersonViewModel> People
        {
            get { return _People; }
        }

        public MainWindowViewModel()
        {
            _People = new ObservableCollection<PersonViewModel>();

            LoadPeople();
        }
         

        public void LoadPeople()
        {
            //TODO: Load all of people returned from DataService.GetPeople()
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}