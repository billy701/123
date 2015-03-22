using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanYuMatch
{
    [Serializable]
    public class Set
    {
        public string Title { get; set; }
        
        public TimeSpan Time { get; set; }
        public int Count { get; set; }
    }
}
