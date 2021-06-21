using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimiSoft.BML
{
   public class Misc
    {
        public static decimal totalPago;
        public static decimal pago;
        public static int idFPago;
        public static bool actualiza = false;

        #region Singleton
        private static volatile Misc instance = null;
        private static readonly object padlock = new object();
        private Misc() { }

        public static Misc Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new Misc();
            return instance;
        }
        #endregion
    }
}
