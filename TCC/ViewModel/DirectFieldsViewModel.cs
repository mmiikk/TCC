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
    public class DirectFieldsViewModel : ViewModelBase
    {
        private Value _Val { get; set; }
        private ObservableCollection<PLC> _PLCs { get; set; }
        private PLC _SelectedPLC { get; set; }
        RelayCommand<string> SetActiveDBTypeCommand { get; set; }
        private string _DBPanel;
        private string _DBStation;
        private string _DBManual;
        public DirectFieldsViewModel()
        {
            Val = new Value();
            PLCs = new ObservableCollection<PLC>();
            SelectedPLC = new PLC();
            SetActiveDBTypeCommand = new RelayCommand<string>(SetActiveDBType);
            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.Val = MessageStaticValue.Val;
                if(this.Val.DBPanel)
                {
                    DBPanel = this.Val.DB.ToString();
                    if (this.Val.Station_ID > 100)
                        DBStation = (400 + (this.Val.Station_ID - 1) - 100).ToString();
                    else
                        DBStation = (400 + (this.Val.Station_ID - 1)).ToString();
                }
                if (this.Val.DBStation)
                {
                    DBStation = this.Val.DB.ToString();
                    if (this.Val.Station_ID > 100)
                        DBPanel = (1050 + (this.Val.Station_ID - 1) - 100).ToString();
                    else
                        DBPanel = (1050 + (this.Val.Station_ID - 1)).ToString();
                }

            });
            Messenger.Default.Register<MessagePLCs>(this, (MessagePLCs) =>
            {
                this.PLCs = MessagePLCs.PLCs;
            });
        }

        void SetActiveDBType(string Type)
        {
            if (Type == "Station")
                Val.DBType = 1;
            if (Type == "Panel")
                Val.DBType = 0;
            if (Type == "Manual")
                Val.DBType = 2;

        }

        public ObservableCollection<PLC> PLCs
        {
            get { return _PLCs; }
            set
            {
                _PLCs = value;
                RaisePropertyChanged("PLCs");
            }
        }

        public PLC SelectedPLC
        {
            get { return _SelectedPLC; }
            set
            {
                _SelectedPLC = value;
                RaisePropertyChanged("SelectedPLC");
            }
        }

        public Value Val
        {
            get { return _Val; }
            set
            {
                _Val = value;
                RaisePropertyChanged("Val");
            }
        }


        public string DBPanel
        {
            get { return _DBPanel; }
            set
            {
                _DBPanel = value;
                RaisePropertyChanged("DBPanel");

            }
        }

        public string DBStation
        {
            get { return _DBStation; }
            set
            {
                _DBStation = value;
                RaisePropertyChanged("DBStation");

            }
        }

        public string DBManual
        {
            get { return _DBManual; }
            set
            {
                _DBManual = value;
                RaisePropertyChanged("DBManual");

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
