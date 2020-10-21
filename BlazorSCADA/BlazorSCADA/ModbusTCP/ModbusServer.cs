using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorSCADA.ModbusTCP
{
    public class ModbusServer
    {

    };
    public class ModbusMaster
    {
        public string slaveIP { get; set; }
        public ushort slavePort { get; set; }

        public bool isConnect = false;
        public ModbusTCP.ModbusServerService MBmaster { get; set; }


    }
    public class RcvData
    { 
    
    }
}
