using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace VehicleGarage.DBCStores
{
    public struct DbcHeader
    {
        public int Signature;
        public int RecordsCount;
        public int FieldsCount;
        public int RecordSize;
        public int StringTableSize;

        public bool IsDBC
        {
            get { return Signature == 0x43424457; }
        }

        public long DataSize
        {
            get { return (long)(RecordsCount * RecordSize); }
        }

        public long StartStringPosition
        {
            get { return DataSize + (long)Marshal.SizeOf(typeof(DbcHeader)); }
        }
    };
}
