using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.MessageInfrastructure;
using TCC.Model;

namespace TCC.ViewModel
{
    public class StaticValuesTextViewModel : ViewModelBase
    {
        string _StaticText = "";
        int _Type = 0;
        private Value _Val { get; set; }

        public StaticValuesTextViewModel()
        {
            Val = new Value();
            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.Val = MessageStaticValue.Val;
                if (MessageStaticValue.Val.Val != "")
                    this.StaticText = MessageStaticValue.Val.Val;
                else
                    this.StaticText = "0";
                this.Type = MessageStaticValue.Val.ID;
            });
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

        public string StaticText
        {
            get { return _StaticText; }
            set
            {
                _StaticText = value;
                RaisePropertyChanged("StaticText");
            }
        }

        public int Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                RaisePropertyChanged("Type");
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
