using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections;
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
        public RelayCommand<object> SendSelectedElementsCommand { get; set; }
        public ElementsGridViewModel()
        {
            Elements = new ObservableCollection<Element>();
            
            SendSelectedElementsCommand = new RelayCommand<object>(SendSelectedElements);
            Messenger.Default.Register<MessageElementsFromDB>(this, (MessageElementsFromDB) =>
            {
                this.Elements = MessageElementsFromDB.ElementsFromDB;
            });
        }

        void SendSelectedElements(object SelectedElementsDataGrid)
        {
            ObservableCollection<Element> SelectedElements = new ObservableCollection<Element>();
            IList SelectedElementsList = SelectedElementsDataGrid as IList;
            foreach (Element el in SelectedElementsList)
            {
                SelectedElements.Add(el);
            }
            Messenger.Default.Send<MessageSelectedElements>(new MessageSelectedElements()
            {
                SelectedElements = SelectedElements
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
