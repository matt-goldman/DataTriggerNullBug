using DataTriggerNullBug.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataTriggerNullBug.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Person> People { get; set; }
    
    private Person _selectedPerson;

    public Person SelectedPerson
    {
        get => _selectedPerson;
        set
        {
            _selectedPerson = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        People = new ObservableCollection<Person>
        {
            new Person
            {
                Name = "Bob",
                DOB = new DateTime(1980, 1, 1)
            },
            new Person
            {
                Name = "Sue",
                DOB = new DateTime(1985, 1, 1)
            },
            new Person
            {
                Name = "Joe",
                DOB = new DateTime(1990, 1, 1)
            },
            new Person
            {
                Name = "Jane",
                DOB = new DateTime(1995, 1, 1)
            }
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
