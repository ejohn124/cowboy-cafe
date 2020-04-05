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
        private List<string> itemPrices = new List<string>();
        public event PropertyChangedEventHandler PropertyChanged;
        public double Subtotal { get; set; }

        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        public IEnumerable<string> ItemPrices { get { return itemPrices.ToArray(); } }


        public void Add(IOrderItem item) 
        {
            items.Add(item);
            itemPrices.Add(item.Price.ToString("C"));
            //if(item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged += OnItemChanged; //FIX ME
            Subtotal += item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));

        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            //if (item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged -= OnItemChanged; //FIX ME
            
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
