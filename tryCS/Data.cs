using System;
using System.Dynamic;

namespace cs_lab4
{
    static class HolderData
    {
        public static int dataId { get; private set; }
        public static void Increase() { dataId++; }
    }
    class Data
    {
        public int id { get; set; }
        public int valueNum { get; set; }
        public string valueString { get; set; }
        public Data()
        {
            id = HolderData.dataId;HolderData.Increase();
            valueNum = 0;
            valueString = "default";
        }
        public Data(int val, string str)
        {
            id = HolderData.dataId; HolderData.Increase();
            valueNum = val;
            valueString = str;
        }
        public Data(int id, int val, string str)
        {
            this.id = id;
            valueNum = val;
            valueString = str;
        }
        public override string ToString()
        {
            return "(id: " + this.id.ToString() + "; valueNum: " + this.valueNum + "; valueString: " + this.valueString + ")";
        }

    }
}
