using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWatcher
{
    class Reload
    {
        public int ID = 0;
        public DateTime Date = DateTime.Now;
        public string Name = "Null";
        public string Reason = "Other";
        public Reload(int I, DateTime D, string N, string R)
        {
            this.ID = I;
            this.Date = D;
            this.Name = N;
            this.Reason = R;
        }
    }
}
