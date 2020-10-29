using Microsoft.AspNetCore.Mvc.Formatters;
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
        public ModbusTCP.ModbusService.Server MBmaster { get; set; }


    }
    public class ModbusData
    {
        public int Address { get;set; }
        public int RcvData { get; set; }
        public bool isWritable = true;
        public bool isReadable = true;   
        
    }
}
