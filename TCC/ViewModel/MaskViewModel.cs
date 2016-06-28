using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.MessageInfrastructure;
using TCC.Model;

namespace TCC.ViewModel
{
    public class MaskViewModel : ViewModelBase
    {
        private ObservableCollection<Mask> _Masks { get; set; }
        public MaskViewModel()
        {
            Masks = new ObservableCollection<Mask>();
            Messenger.Default.Register<MessageMask>(this, (MessageMask) =>
            {
                this.Masks = MessageMask.MasksFromDB;
            });
        }
        public ObservableCollection<Mask> Masks
        {
            get { return _Masks; }
            set
            {
                _Masks = value;
                RaisePropertyChanged("Masks");

            }
        }
    }
}
