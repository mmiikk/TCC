using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.ComponentModel;
using TCC.MessageInfrastructure;

namespace TCC.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        string _Exception { get; set; }
        bool _ShowDialog { get; set; }

        public RelayCommand CloseDialog { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            CloseDialog = new RelayCommand(Close);
            Messenger.Default.Register<MessageException>(this, (MessageException) =>
            {
                this.Exception = MessageException.Exception;
            });
        }

        public void Close()
        {
            ShowDialog = false;
        }

        public string Exception
        {
            get { return _Exception; }
            set
            {
                value = value.Replace(".", ".\r\n");
                _Exception = value;
                RaisePropertyChanged("Exception");
                
                ShowDialog = true;
            }
        }

        public bool ShowDialog
        {
            get { return _ShowDialog; }
            set
            {
                _ShowDialog = value;
                RaisePropertyChanged("ShowDialog");

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