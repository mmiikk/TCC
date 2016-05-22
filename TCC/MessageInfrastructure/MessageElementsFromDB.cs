using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Model;

namespace TCC.MessageInfrastructure
{
    class MessageElementsFromDB
    {
        public ObservableCollection<Element> ElementsFromDB { get; set; }
        public int StationID { get; set; }
    }
}
