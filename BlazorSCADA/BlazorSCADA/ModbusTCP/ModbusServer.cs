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
        public int[] Address { get; set; }
        public int[] RcvData { get; set; }
        public bool[] isWritable { get; set; }
        public bool[] isReadable { get; set; }

        public ModbusData(int dataNumbers)
        {
            Address = new int[dataNumbers];
            RcvData = new int[dataNumbers];
            isReadable = new bool[dataNumbers];
            isWritable = new bool[dataNumbers];
            for (int i = 0; i < dataNumbers; i++)
            {
                Address[i] = i;
                isReadable[i] = true;
                isWritable[i] = false;
            }
        }
    }
}
