using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Model;

namespace TCC.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        Settings _Set;

        public RelayCommand Save { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public SettingsViewModel()
        {
            Set = new Settings();
            Set.IP = Settings1.Default.ServerIP;
            Set.DBUser = Settings1.Default.DBUser;
            Set.DBPassword = Settings1.Default.DBPassword;
            Set.DBName = Settings1.Default.DBName;
            Save = new RelayCommand(SaveSettings);
        }

        public Settings Set
        {
            get { return _Set; }
            set
            {
                _Set = value;
                RaisePropertyChanged("Set");
            }
        }
        void SaveSettings()
        {
            Settings1.Default.ServerIP = Set.IP;
            Settings1.Default.DBPassword = Set.DBPassword;
            Settings1.Default.DBUser = Set.DBUser;
            Settings1.Default.DBName = Set.DBName;
            Settings1.Default.Save();
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
