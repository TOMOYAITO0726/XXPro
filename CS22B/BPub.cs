using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS22B
{
    private int aaa = 0;
    internal class BPub
    {
        public void GetPublic() { }
        internal void GetInternal() { }
        protected void GetProtected() { }
        internal protected void GetInternalProtected() { }
        private void GetPrivate() { }
    }
}
