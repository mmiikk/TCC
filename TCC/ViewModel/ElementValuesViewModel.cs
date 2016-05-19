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
    public class ElementValuesViewModel : ViewModelBase, INotifyPropertyChanged

    {
        ObservableCollection<Value> _Values;
        Value _ValueID;
        Value _FontColor;
        Value _BackColor;
        Value _Action;
        Value _Visibility;
        Value _CurrentValue;
        bool _DirectVisibility;
        bool _StaticVisibility;
        bool _MaskVisibility;


        ObservableCollection<Element> SelectedElements;
        public RelayCommand<Value> SetActiveValueCommand { get; set; }
        public ElementValuesViewModel()
        {
            Values = new ObservableCollection<Value>();
            ValueID = new Value();
            FontColor = new Value();
            BackColor = new Value();
            Action = new Value();
            Visibility = new Value();
            SelectedElements = new ObservableCollection<Element>();
            SetActiveValueCommand = new RelayCommand<Value>(SetActiveValue);
            CurrentValue = new Value();
            
            DirectVisibility = false;
            StaticVisibility = false;
            MaskVisibility = false;

            Messenger.Default.Register<MessageSelectedElements>(this, (MessageSelectedElements) =>
            {
                this.SelectedElements = MessageSelectedElements.SelectedElements;
                if (this.SelectedElements.Count == 1)
                    ConnectDB();
            });

            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                this.CurrentValue = MessageStaticValue.Val;

                if (ValueID.Selected == true)
                    ValueID = CurrentValue;
            });


            Messenger.Default.Register<MessageStaticValue>(this, (MessageStaticValue) =>
            {
                if ((CurrentValue.ID >= 2000 && _CurrentValue.ID < 3000))
                {
                    BackColor.Val = MessageStaticValue.Val.Val;
                    CurrentValue.Val = MessageStaticValue.Val.Val;
                }

                if ((CurrentValue.ID >= 1000 && CurrentValue.ID < 2000))
                {
                    FontColor.Val = MessageStaticValue.Val.Val;
                    CurrentValue.Val = MessageStaticValue.Val.Val;
                }
            });
        }

        void SetActiveValue(Value val)
        {
            ValueID.Selected = false;
            FontColor.Selected = false;
            BackColor.Selected = false;
            Action.Selected = false;
            Visibility.Selected = false;

            val.Selected = true;
            if ((val.ID >= 4000 && val.ID < 5000))
                MaskVisibility = false;
            else
                MaskVisibility = true;

            if ((val.ID >= 4000 && val.ID < 5000))
                StaticVisibility = false;
            else
                StaticVisibility = true;

            if ((val.ID >= 0 && val.ID < 1000) || (val.ID >= 5000 && val.ID < 6000))
                DirectVisibility = true;
            else
                DirectVisibility = false;

            CurrentValue = val;

           
            Messenger.Default.Send<MessageStaticValue>(new MessageStaticValue()
            {
                Val = this.CurrentValue,
                Type = val.ID
            });

        }

     

        public ObservableCollection<Value> Values
        {
            get { return _Values; }
            set
            {
                _Values = value;
                RaisePropertyChanged("Values");
            }
        }

        public Value CurrentValue
        {
            get { return _CurrentValue; }
            set
            {
                _CurrentValue = value;
                RaisePropertyChanged("CurrentValue");
            }
        }

        public Value FontColor
        {
            get { return _FontColor; }
            set
            {
                _FontColor = value;
                RaisePropertyChanged("FontColor");
            }
        }

        public Value BackColor
        {
            get { return _BackColor; }
            set
            {
                _BackColor = value;
                RaisePropertyChanged("BackColor");
            }
        }

        public Value Action
        {
            get { return _Action; }
            set
            {
                _Action = value;
                RaisePropertyChanged("Action");
            }
        }

        public Value Visibility
        {
            get { return _Visibility; }
            set
            {
                _Visibility = value;
                RaisePropertyChanged("Visibility");
            }
        }

        public Value ValueID
        {
            get { return _ValueID; }
            set
            {
                _ValueID = value;
                RaisePropertyChanged("ValueID");
            }
        }

        public bool DirectVisibility
        {
            get { return _DirectVisibility; }
            set
            {
                _DirectVisibility = value;
                RaisePropertyChanged("DirectVisibility");
            }
        }

        public bool StaticVisibility
        {
            get { return _StaticVisibility; }
            set
            {
                _StaticVisibility = value;
                RaisePropertyChanged("StaticVisibility");
            }
        }

        public bool MaskVisibility
        {
            get { return _MaskVisibility; }
            set
            {
                _MaskVisibility = value;
                RaisePropertyChanged("MaskVisibility");
            }
        }


        void ConnectDB()
        {
            if (SelectedElements.Count == 1)
            {
                
                int ElementID = SelectedElements[0].ID;
                int StationID = SelectedElements[0].Station_ID;
                ConnectDBTask(StationID, ElementID).ContinueWith(task =>
                {
                    Values = task.Result;
                    ValueID = Values.FirstOrDefault(p => p.ID == ElementID);
                    FontColor = Values.FirstOrDefault(p => p.ID == (ElementID + 1000));
                    BackColor = Values.FirstOrDefault(p => p.ID == (ElementID + 2000));
                    Action = Values.FirstOrDefault(p => p.ID == (ElementID + 4000));
                    Visibility = Values.FirstOrDefault(p => p.ID == (ElementID + 5000));
                    ValueID.Selected = true;
                    SetActiveValue(ValueID);

                }, TaskContinuationOptions.NotOnFaulted);
            }

        }
        static Task<ObservableCollection<Value>> ConnectDBTask(int StationID, int ElementID)
        {
            ObservableCollection<Value> Values;

            return Task<ObservableCollection<Value>>.Factory.StartNew(() =>
            {
                try
                {
                    return Values = DataAccessService.Instance.GetAllValues(StationID, ElementID);
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

    }
}
