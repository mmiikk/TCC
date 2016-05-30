using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Model;

namespace TCC.ViewModel
{
    public class ColorPickerViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public ObservableCollection<Color> Colors { get; set; }
        private Color _SelectedColor { get; set; }
        public RelayCommand<string> ColorClickCommand { get; set; }
        public ColorPickerViewModel()
        {
            Colors = new ObservableCollection<Color>();
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(84 + (i-1)*(255-84)/7,0,0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(84 + (i - 1) * 24, 53 + (i - 1) * 16, 0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(84 + (i - 1) * 24, 82 + (i - 1) * 24, 0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0, 84 + (i - 1) * 24, 0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0, 84 + (i - 1) * 24, 82 + (i - 1) * 24));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0, 0, 84 + (i - 1) * 24));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(82 + (i - 1) * 24, 0, 84 + (i - 1) * 24));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0 + (i - 1) * 36, 0 + (i - 1) * 36, 0 + (i - 1) * 36));

            ColorClickCommand = new RelayCommand<string>(ColorClicked);
            SelectedColor = new Color(1, 1, 1);
            
        }

        private void ColorClicked(string obj)
        {
            SelectedColor = Colors.FirstOrDefault(a => a.RGB == obj);
        }

        public Color SelectedColor
        {
            get { return _SelectedColor; }
            set
            {
                _SelectedColor = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("SelectedColor");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
