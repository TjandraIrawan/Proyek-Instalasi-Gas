using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic_Projec2017
{
    class GlobalVariable
    {
        private static string v_Global = "";

        public static string UserId
        {
            get { return v_Global; }
            set { v_Global = value; }
        }
        public static string InvId
        {
            get { return v_Global; }
            set { v_Global = value; }
        }
        public static string CustId
        {
            get { return v_Global; }
            set { v_Global = value; }
        }
    }
}
