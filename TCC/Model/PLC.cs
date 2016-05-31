using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class PLC : INotifyPropertyChanged
    {
        private int _ID = 0;
        private string _Name = string.Empty;

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
