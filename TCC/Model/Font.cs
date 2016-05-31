using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Font : INotifyPropertyChanged
    {
        private int _ID { get; set; }
        private int _Station_ID { get; set; }
        private int _Size { get; set; }
        private bool _Bold { get; set; }
        private bool _Italic { get; set; }
        private bool _Underline { get; set; }
        private bool _CenterAlign { get; set; }

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("ID");
            }
        }

        public int Station_ID
        {
            get { return _Station_ID; }
            set
            {
                _Station_ID = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Station_ID");
            }
        }

        public int Size
        {
            get { return _Size; }
            set
            {
                _Size = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Size");
            }
        }

        public bool Bold
        {
            get { return _Bold; }
            set
            {
                _Bold = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Bold");
            }
        }

        public bool Italic
        {
            get { return _Italic; }
            set
            {
                _Italic = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Italic");
            }
        }

        public bool Underline
        {
            get { return _Underline; }
            set
            {
                _Underline = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Underline");
            }
        }

        public bool CenterAlign
        {
            get { return _CenterAlign; }
            set
            {
                _CenterAlign = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("CenterAlign");
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
