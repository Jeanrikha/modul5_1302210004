using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210004
{
    internal class SimpleDataBase<T>
    {
        private List<T> storeData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storeData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(T newData)
        {
            this.inputDates.Add(DateTime.Now);
            this.storeData.Add(newData);
        }
        public void PrintAllData()
        {
            for(int i = 0; i < this.storeData.Count; i++)
            {
                Console.WriteLine("Data "+(i+1)+" berisi: " + storeData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
           
        }
    }
}
