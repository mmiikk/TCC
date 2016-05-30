using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TCC.Model
{
    public class Color : INotifyPropertyChanged
    {
        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        private int _R { get; set; }
        private int _G { get; set; }
        private int _B { get; set; }
        private string _iRGB { get; set; }
        


        public int R
        {
            get { return _R; }
            set
            {
                _R = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("R");
            }
        }

        public int G
        {
            get { return _G; }
            set
            {
                _G = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("G");
            }
        }

        public int B
        {
            get { return _B; }
            set
            {
                _B = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("B");
            }
        }

        public string iRGB
        {
            get { return ((R+256*G+256*256*B).ToString()); }
            set
            {
                _iRGB = value;
                OnPropertyChanged("iRGB");

            }
        }



        public string RGB
        {
            get { return System.Windows.Media.Color.FromRgb(Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B)).ToString(); }
           
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
