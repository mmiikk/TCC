using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Model
{
    public class Element
    {
        public int ID { get; set; }
        public int Position_X { get; set; }
        public int Position_Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool ShowBorder { get; set; }
        public string Name { get; set; }
        public bool ShowName { get; set; }
        public string Position_Name { get; set; }
        public bool OnTop { get; set; }
    }
}
