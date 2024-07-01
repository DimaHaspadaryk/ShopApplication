using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{
    internal class Product
    {
        int id;

        string name;

        string producer;

        public Product(int id, string name, string producer)
        {
            this.id = id;
            this.name = name;
            this.producer = producer;
        }

        public int getId() {
            return id; 
        }
        public string getName() { 
            return name; 
        }
        public string getProducer() { 
            return producer; 
        }
        public void setProducer(string producer)
        {
            this.producer = producer;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name) {
            this.name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
