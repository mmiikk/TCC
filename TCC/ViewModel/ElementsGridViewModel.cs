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
    public class ElementsGridViewModel : ViewModelBase
    {
        ObservableCollection<Element> _Elements;
        public ElementsGridViewModel()
        {
            Elements = new ObservableCollection<Element>();
            Messenger.Default.Register<MessageElementsFromDB>(this, (MessageElementsFromDB) =>
            {
                this.Elements = MessageElementsFromDB.ElementsFromDB;
            });
        }

        public ObservableCollection<Element> Elements
        {
            get { return _Elements; }
            set
            {
                _Elements = value;
                RaisePropertyChanged("Elements");
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
