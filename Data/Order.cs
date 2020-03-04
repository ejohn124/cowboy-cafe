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
            if(item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged += OnItemChanged; //FIX ME
            Subtotal += item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            if (item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged -= OnItemChanged; //FIX ME
            
            Subtotal -= item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            }


        }
    }
}
