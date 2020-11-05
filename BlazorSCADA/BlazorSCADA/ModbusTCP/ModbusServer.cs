using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public ushort Address { get; set; }
        public ushort revData { get; set; }
        public ushort inputData { get; set; }
        public bool isWritable { get; set; }
        public bool isReadable { get; set; }
        public bool isFocus { get; set; }


    }
}
