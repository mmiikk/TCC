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
    public class ElementParametersViewModel : ViewModelBase
    {
        Element _SelectedElement;
        Font _SelectedFont;
        ObservableCollection<Element> _SelectedElements;
        public RelayCommand<string> TooglePropertyCommand { get; set; }
        bool _Show;

        public ElementParametersViewModel()
        {
            SelectedElement = new Element();
            TooglePropertyCommand = new RelayCommand<string>(ToogleProperty);
            Show = false;
            SelectedElements = new ObservableCollection<Element>();
            Messenger.Default.Register<MessageSelectedElements>(this, (MessageSelectedElements) =>
            {
                this.SelectedElements = MessageSelectedElements.SelectedElements;
            });
        }

        void ToogleProperty(string Property)
        {
            Font _newFont = new Font();
            _newFont = SelectedFont;
            if(Property == "Bold")
            {
                if (SelectedFont.Bold == true)
                    _newFont.Bold = false;
                else
                    _newFont.Bold = true;
            }
            if (Property == "Italic")
            {
                if (SelectedFont.Italic == true)
                    _newFont.Italic = false;
                else
                    _newFont.Italic = true;
            }
            if (Property == "Underline")
            {
                if (SelectedFont.Underline == true)
                    _newFont.Underline = false;
                else
                    _newFont.Underline = true;
            }
            if (Property == "CenterAlign")
            {
                if (SelectedFont.CenterAlign == true)
                    _newFont.CenterAlign = false;
                else
                    _newFont.CenterAlign = true;
            }

            SelectedFont = _newFont;
        }

        public ObservableCollection<Element> SelectedElements
        {
            get { return _SelectedElements; }
            set
            {
                _SelectedElements = value;
                RaisePropertyChanged("SelectedElements");
                if (SelectedElements.Count == 1)
                {
                    SelectedElement = SelectedElements[0];
                    ConnectDB();
                    Show = true;
                }
                else
                {
                    SelectedElement = new Element();
                    Show = false;
                }
            }
        }

        void ConnectDB()
        {
            ConnectDBTask(SelectedElement.Station_ID,SelectedElement.ID).ContinueWith(task =>
            {
                SelectedFont = task.Result;
                
                
            }, TaskContinuationOptions.NotOnFaulted);

        }
        static Task<Font> ConnectDBTask(int StationID, int ElementID)
        {
            Font font;

            return Task<Font>.Factory.StartNew(() =>
            {
                try
                {
                    return font = DataAccessService.Instance.GetFont(StationID,ElementID);
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

        public Element SelectedElement
        {
            get { return _SelectedElement; }
            set
            {
                _SelectedElement = value;
                RaisePropertyChanged("SelectedElement");
            }
        }

        public Font SelectedFont
        {
            get { return _SelectedFont; }
            set
            {
                _SelectedFont = value;
                RaisePropertyChanged("SelectedFont");
            }
        }


        public bool Show
        {
            get { return _Show; }
            set
            {
                _Show = value;
                RaisePropertyChanged("Show");
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
