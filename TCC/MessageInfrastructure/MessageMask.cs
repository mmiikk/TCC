﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Model;

namespace TCC.MessageInfrastructure
{
    class MessageMask
    {
        public ObservableCollection<Mask> MasksFromDB { get; set; }
    }
}
