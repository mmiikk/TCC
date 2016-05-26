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
    public class ThinClientConnectViewModel : ViewModelBase
    {
        ObservableCollection<int> _TCIDs;
        ObservableCollection<int> _SFCSs;
        int _TCID;
        int _SFCS;
        bool _isConnecting;
        public RelayCommand Connect { get; set; }
        
        public ThinClientConnectViewModel()
        {
            isConnecting = true;
            Connect = new RelayCommand(ConnectDB);
            TCIDs = new ObservableCollection<int>();
            SFCSs = new ObservableCollection<int>();
            for (int i = 1; i <= 70; i++)
                TCIDs.Add(i);
            for (int i = 1; i <= 2; i++)
                SFCSs.Add(i);
        }

        public bool isConnecting
        {
            get { return _isConnecting; }
            set
            {
                _isConnecting = value;
                RaisePropertyChanged("isConnecting");
            }
        }

        public ObservableCollection<int> TCIDs
        {
            get { return _TCIDs; }
            set
            {
                _TCIDs = value;
                RaisePropertyChanged("TCIDs");
            }
        }

        public ObservableCollection<int> SFCSs
        {
            get { return _SFCSs; }
            set
            {
                _SFCSs = value;
                RaisePropertyChanged("SFCSs");
            }
        }

        public int TCID
        {
            get { return _TCID; }
            set
            {
                _TCID= value;
                RaisePropertyChanged("TCID");
            }
        }

        public int SFCS
        {
            get { return _SFCS; }
            set
            {
                _SFCS = value;
                RaisePropertyChanged("SFCS");
            }
        }



        public void ConnectDB()
        {
            isConnecting = false;
            ConnectDBTask(TCID, SFCS).ContinueWith(task =>
             {
                 ObservableCollection<Element> Elements;
                 Elements = task.Result;
                 if (Elements != null)
                 {
                     Messenger.Default.Send<MessageElementsFromDB>(new MessageElementsFromDB()
                     {
                         ElementsFromDB = Elements
                     });
                     
                 }
                 isConnecting = true;

             }, TaskContinuationOptions.NotOnFaulted);


             LoadPLC().ContinueWith( task =>
             {
                 ObservableCollection<PLC> PLCs;
                 PLCs = task.Result;
                 if (PLCs != null)
                 {
                     Messenger.Default.Send<MessagePLCs>(new MessagePLCs()
                     {
                          PLCs = PLCs
                     });

                 }
                 isConnecting = true;

             }, TaskContinuationOptions.NotOnFaulted);

        }
        static Task<ObservableCollection<Element>> ConnectDBTask(int TCID, int SFCS)
        {
            ObservableCollection<Element> Elements;
            
            return Task<ObservableCollection<Element>>.Factory.StartNew(() =>
            {
                try
                {
                return Elements = DataAccessService.Instance.GetAllElements(TCID + (SFCS - 1) * 100);
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

        static Task<ObservableCollection<PLC>> LoadPLC()
        {
            ObservableCollection<PLC> Elements;

            return Task<ObservableCollection<PLC>>.Factory.StartNew(() =>
            {
                try
                {
                    return Elements = DataAccessService.Instance.GetAllPLCs();
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
