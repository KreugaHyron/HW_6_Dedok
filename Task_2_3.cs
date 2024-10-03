using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_Dedok
{
    public class Store : IDisposable
    {
        private string storeName;
        private string storeAddress;
        private string storeType;
        private bool disposed = false;
        public enum StoreType
        {
            Grocery,    
            Hardware,   
            Clothing,   
            Footwear    
        }
        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }
        public string StoreAddress
        {
            get { return storeAddress; }
            set { storeAddress = value; }
        }
        public StoreType TypeOfStore { get; set; }
        public Store(string name, string address, StoreType typeOfStore)
        {
            StoreName = name;
            StoreAddress = address;
            TypeOfStore = typeOfStore;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Store Name: {StoreName}");
            Console.WriteLine($"Store Address: {StoreAddress}");
            Console.WriteLine($"Store Type: {TypeOfStore}");
        }
        ~Store()
        {
            Console.WriteLine("Destructor called for Store.");
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing managed resources.");
                }

                Console.WriteLine("Disposing unmanaged resources.");
                disposed = true;
            }
        }
    }
}
