using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Mask : INotifyPropertyChanged
    {
        private int _ID { get; set; }
        private int _Station_ID { get; set; }
        private int _Position { get; set; }
        private string _Value { get; set; }
        private string _MaskVal { get; set; }


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

        public int Position
        {
            get { return _Position; }
            set
            {
                _Position = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Position");
            }
        }

        public string Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Value");
            }
        }

        public string MaskVal
        {
            get { return _MaskVal; }
            set
            {
                _MaskVal = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("MaskVal");
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
