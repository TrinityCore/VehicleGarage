using System.Runtime.InteropServices;

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
            get { return RecordsCount * RecordSize; }
        }

        public long StartStringPosition
        {
            get { return DataSize + Marshal.SizeOf(typeof(DbcHeader)); }
        }
    };
}
