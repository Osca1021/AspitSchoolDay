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
                @"Programmering bruges i mange typer applikationer
F.eks.:",
                "Apps til telefoner og tablets",
                "Software til computere",
                "Smarte køleskabe, vaskemaskiner m.m.",
                "Denne App er programmeret i sproget C# (C Sharp), ét af de sprog der undervises i, i faget Softwarekonstruktion"
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