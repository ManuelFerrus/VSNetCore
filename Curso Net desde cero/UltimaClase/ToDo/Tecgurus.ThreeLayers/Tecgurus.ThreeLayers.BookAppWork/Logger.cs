using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ThreeLayers.BookApp
{
    public class Logger
    {
        public static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        //TODO
        public static NLog.Logger loggerDataBase = LogManager.GetLogger("database"); // es el nombre que se puso en el nlog.config

    }
}
