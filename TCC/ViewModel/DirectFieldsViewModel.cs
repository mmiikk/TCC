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
using TCC.Services;

namespace TCC.ViewModel
{
    public class DirectFieldsViewModel : ViewModelBase
    {
        private Value _Val { get; set; }
        private ObservableCollection<PLC> _PLCs { get; set; }
        private ObservableCollection<Mask> _Masks { get; set; }
        private PLC _SelectedPLC { get; set; }
        public RelayCommand<string> SetActiveDBTypeCommand { get; set; }
        public RelayCommand<string> SetActiveTypeCommand { get; set; }

        private string _DBPanel;
        private string _DBStation;
        private string _DBManual;
        public DirectFieldsViewModel()
        {
            Val = new Value();
            PLCs = new ObservableCollection<PLC>();
            Masks = new ObservableCollection<Mask>();
            SelectedPLC = new PLC();
            SetActiveDBTypeCommand = new RelayCommand<string>(SetActiveDBType);
            SetActiveTypeCommand = new RelayCommand<string>(SetActiveType);
            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.Val = MessageStaticValue.Val;
               
                if (this.Val.Station_ID > 100)
                {
                    DBStation = (400 + (this.Val.Station_ID - 1) - 100).ToString();
                    DBPanel = (1050 + (this.Val.Station_ID - 1) - 100).ToString();
                }
                else
                {
                    DBStation = (400 + (this.Val.Station_ID - 1)).ToString();
                    DBPanel = (1050 + (this.Val.Station_ID - 1)).ToString();
                }
                if (this.Val.Mask_ID != 0)
                    ConnectDB();

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

        void SetActiveType(string Type)
        {
            Value _val = new Value();
            _val = Val;
            _val.Type = Type;
            Val = _val;

        }

        void ConnectDB()
        {
            ConnectDBTask(Val.Station_ID, Val.Mask_ID).ContinueWith(task =>
            {
                Masks = task.Result;


            }, TaskContinuationOptions.NotOnFaulted);

        }
        static Task<ObservableCollection<Mask>> ConnectDBTask(int StationID, int ElementID)
        {
            ObservableCollection<Mask> masks = new ObservableCollection<Mask>();

            return Task<ObservableCollection<Mask>>.Factory.StartNew(() =>
            {
                try
                {
                    return masks = DataAccessService.Instance.GetMasks(StationID, ElementID);
                }
                catch (Exception ex)
                {
                    Messenger.Default.Send<MessageException>(new MessageException()
                    {
                        Exception = ex.Message.ToString()
                    });

                    return null;
                }
            });
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

        public ObservableCollection<Mask> Masks
        {
            get { return _Masks; }
            set
            {
                _Masks = value;
                RaisePropertyChanged("Masks");
                Messenger.Default.Send<MessageMask>(new MessageMask()
                {
                    MasksFromDB = Masks
                });
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
