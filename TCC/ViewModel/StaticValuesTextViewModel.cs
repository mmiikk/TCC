using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.MessageInfrastructure;

namespace TCC.ViewModel
{
    public class StaticValuesTextViewModel : ViewModelBase
    {
        string _StaticText = "";

        public StaticValuesTextViewModel()
        {
            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.StaticText = MessageStaticValue.Val.Val;
            });
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
