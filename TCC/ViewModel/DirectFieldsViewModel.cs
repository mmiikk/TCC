using GalaSoft.MvvmLight;
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
        public DirectFieldsViewModel()
        {
            Val = new Value();
            PLCs = new ObservableCollection<PLC>();
            SelectedPLC = new PLC();
            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.Val = MessageStaticValue.Val;
                
            });
            Messenger.Default.Register<MessagePLCs>(this, (MessagePLCs) =>
            {
                this.PLCs = MessagePLCs.PLCs;
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
