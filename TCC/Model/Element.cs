using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Element : INotifyPropertyChanged
    {
        private int _ID { get; set; }
        private int _Station_ID { get; set; }
        private int _Position_X { get; set; }
        private int _Position_Y { get; set; }
        private int _Width { get; set; }
        private int _Height { get; set; }
        private bool _ShowBorder { get; set; }
        private string _Name { get; set; }
        private bool _ShowName { get; set; }
        private string _Position_Name { get; set; }
        private bool _OnTop { get; set; }

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

        public int Position_X
        {
            get { return _Position_X; }
            set
            {
                _Position_X = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Position_X");
            }
        }

        public int Position_Y
        {
            get { return _Position_Y; }
            set
            {
                _Position_Y = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Position_Y");
            }
        }

        public int Width
        {
            get { return _Width; }
            set
            {
                _Width = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Width");
            }
        }

        public int Height
        {
            get { return _Height; }
            set
            {
                _Height = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Height");
            }
        }

        public bool ShowBorder
        {
            get { return _ShowBorder; }
            set
            {
                _ShowBorder = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("ShowBorder");
            }
        }

        public bool ShowName
        {
            get { return _ShowName; }
            set
            {
                _ShowName = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("ShowName");
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Name");
            }
        }

        public string Position_Name
        {
            get { return _Position_Name; }
            set
            {
                _Position_Name = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Position_Name");
            }
        }

        public bool OnTop
        {
            get { return _OnTop; }
            set
            {
                _OnTop = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("OnTop");
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
