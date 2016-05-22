using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Settings
    {
        private string _IP = string.Empty;
        private string _DBUser = string.Empty;
        private string _DBPassword = string.Empty;
        private string _DBName = string.Empty;

        public string IP
        {
            get { return _IP; }
            set
            {
                _IP = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("IP");
            }
        }

        public string DBUser
        {
            get { return _DBUser; }
            set
            {
                _DBUser = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("DBUser");
            }
        }

        public string DBPassword
        {
            get { return _DBPassword; }
            set
            {
                _DBPassword = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("DBPassword");
            }
        }

        public string DBName
        {
            get { return _DBName; }
            set
            {
                _DBName = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("DBName");
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
