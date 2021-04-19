using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ThreeLayers.ExampleApp.WindowFormApp
{
    public class Logger
    {
        //creamos el objeto instanceado a la clase Nlog
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
