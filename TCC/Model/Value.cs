using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Value : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public int _Station_ID { get; set; }
        private string _Type = String.Empty;
        public int DB { get; set; }
        public int StartByte { get; set; }
        public int Length { get; set; }
        private string _Val = String.Empty;
        private int _Mask_ID = 0;
        private int _DBType { get; set; }
        private PLC _oPLC = new PLC();
        private bool _Selected = false;
        private string _TypeVisibility = String.Empty;
        private bool _TagTypeVisibility = false;
        private bool _DBStation = false;
        private bool _DBPanel = false;
        private bool _DBManual = false;


        public PLC oPLC
        {
            get { return _oPLC; }
            set
            {
                _oPLC = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("oPLC");
            }
        }

        public string Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                SetTypeVisibility();
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Type");
            }
        }

        public string TypeVisibility
        {
            get { return _TypeVisibility; }
            set
            {
                _TypeVisibility = value;
                OnPropertyChanged("TypeVisibility");

            }
        }

        public string Val
        {
            get { return _Val; }
            set
            {
                _Val = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Val");
            }
        }

        public int Station_ID
        {
            get { return _Station_ID; }
            set
            {
                _Station_ID = value;
                OnPropertyChanged("Station_ID");
            }
        }

        public int Mask_ID
        {
            get { return _Mask_ID; }
            set
            {
                _Mask_ID = value;
                SetTypeVisibility();
                OnPropertyChanged("Mask_ID");
            }
        }

        public int DBType
        {
            get { return _DBType; }
            set
            {
                _DBType = value;
                OnPropertyChanged("DBType");

                switch (_DBType)
                {
                    case 1:
                        DBStation = true;
                        DBPanel = false;
                        DBManual = false;
                        break;
                    case 0:
                        DBStation = false;
                        DBPanel = true;
                        DBManual = false;
                        break;
                    case 2:
                        DBStation = false;
                        DBPanel = false;
                        DBManual = true;
                        break;
                    default:
                        DBStation = false;
                        DBPanel = false;
                        DBManual = false;
                        break;
                }


            }
        }


        public bool Selected
        {
            get { return _Selected; }
            set
            {
                _Selected = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Selected");
            }
        }

        public bool DBStation
        {
            get { return _DBStation; }
            set
            {
                _DBStation = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("DBStation");
            }
        }

        public bool DBPanel
        {
            get { return _DBPanel; }
            set
            {
                _DBStation = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("DBPanel");
            }
        }

        public bool DBManual
        {
            get { return _DBManual; }
            set
            {
                _DBManual = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("DBManual");
            }
        }

        public bool TagTypeVisibility
        {
            get { return _TagTypeVisibility; }
            set
            {
                _TagTypeVisibility = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("TagTypeVisibility");
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

        protected void SetTypeVisibility()
        {
            if (this.Type == "Static")
            {
                this.TypeVisibility = "Static";
            }
            else
            {
                this.TagTypeVisibility = true;
                if (this.Mask_ID == 0 && this.Type != "Static")
                {
                    this.TypeVisibility = "Direct";
                }
                else
                {
                    this.TypeVisibility = "Mask";
                }
            }
        }
    
}
}
