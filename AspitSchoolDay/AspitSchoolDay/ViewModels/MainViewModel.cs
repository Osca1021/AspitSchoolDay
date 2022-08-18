using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AspitSchoolDay
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<string> texts;

        public MainViewModel()
        {
            List<string> newTexts = new List<string>
            {
                "This page 1",
                "is page 2",
                "page 3: Det at programmere på aspit er et meget spændende job for alle dem der godt kan lide at programmere. man lærer også at programmere hvis det er det som man gerne vil.",
                "second to last page 4",
                "last page 5"
            };

            Texts = newTexts;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        public List<string> Texts
        {
            get => texts;
            set => SetProperty(ref texts, value);
        }
    }
}