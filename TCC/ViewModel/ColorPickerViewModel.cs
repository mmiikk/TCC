using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.MessageInfrastructure;
using TCC.Model;

namespace TCC.ViewModel
{
    public class ColorPickerViewModel : ViewModelBase
    {
        public ObservableCollection<Color> Colors { get; set; }
        private Color _SelectedColor { get; set; }
        public RelayCommand<string> ColorClickCommand { get; set; }

        bool _Show = false;
        private Value _Val { get; set; }
        private int _ValID {get; set;}
      
        public ColorPickerViewModel()
        {
            Colors = new ObservableCollection<Color>();
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(84 + (i-1)*(255-84)/7,0,0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(84 + (i - 1) * (255-84)/7, 53 + (i - 1) * (161-53)/7, 0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(84 + (i - 1) * (255-84)/7, 82 + (i - 1) * (250-82)/7, 0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0, 84 + (i - 1) * (255 - 84) / 7, 0));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0, 84 + (i - 1) * (255 - 84) / 7, 82 + (i - 1) * (250 - 82) / 7));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0, 0, 84 + (i - 1) * (255 - 84) / 7));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(82 + (i - 1) * (250 - 82) / 7, 0, 84 + (i - 1) * (255 - 84) / 7));
            for (int i = 1; i <= 8; i++)
                Colors.Add(new Color(0 + (i - 1) * 255/7, 0 + (i - 1) * 255/7, 0 + (i - 1) * 255/7));

           
            ColorClickCommand = new RelayCommand<string>(ColorClicked);
            SelectedColor = new Color(1, 1, 1);
            Show = false;

            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.Val = MessageStaticValue.Val;
                this.ValID = MessageStaticValue.Val.ID;
                if ((_ValID >= 2000 && _ValID < 3000) || (_ValID >= 1000 && _ValID < 2000))
                {
                    SelectedColor.RGB = this.Val.Val;
                    Show = true;

                }
                else
                {
                    Show = false;
                }
            });

        }

        public bool Show
        {
            get { return _Show; }
            set
            {
                _Show = value;
                RaisePropertyChanged("Show");
            }
        }

        public Value Val
        {
            get { return _Val; }
            set
            {
                _Val = value;
                OnPropertyChanged("Val");
            }
        }


        public int ValID
        {
            get { return _ValID; }
            set
            {
                _ValID = value;
                OnPropertyChanged("ValID");
            }
        }

        private void ColorClicked(string obj)
        {
            Color col = Colors.FirstOrDefault(a => a.RGB == obj);
            SelectedColor.RGB = col.iRGB;
            // SelectedColor = new Color(col.R, col.G, col.B);
            sendSelectedColor();

        }

        public Color SelectedColor
        {
            get { return _SelectedColor; }
            set
            {
                _SelectedColor = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("SelectedColor");

                sendSelectedColor();
               
            }
        }

        public void sendSelectedColor()
        {
            if (Val != null)
            {
                Val.Val = SelectedColor.iRGB;
                Messenger.Default.Send<MessageStaticValue>(new MessageStaticValue()
                {
                    Val = this.Val,
                    Type = ValID
                });
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
