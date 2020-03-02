using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {
        private uint lastOrderNumber;
        private List<IOrderItem> items = new List<IOrderItem>();
        public event PropertyChangedEventHandler PropertyChanged;
        public double Subtotal { get; set; }

        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            Subtotal += item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            Subtotal -= item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
