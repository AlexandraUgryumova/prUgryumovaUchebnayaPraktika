﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1_zad2
{
    class Shop
    {
        private Dictionary<Product, int> products;

        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }

        public void AddProduct (Product product, int count)
        {
            products.Add(product, count);
        }

        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }


        public void WriteAllProducts (ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Key.GetInfo()}; Количество: {product.Value}");
            }
        }
        bool amount = true;
        public bool amountReturn ()
        {
            return amount;
        }
        public void Sell (Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    amount = false;
                } else
                {
                    amount = true;
                    if (count < 0)
                        count *= -1;
                    else if (count == 0)
                        count += 1;
                    products[product] -= count;
                }
            } else
            {
                MessageBox.Show("Товар не найден!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Sell (string ProductName, int count)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell, count);
            } else
            {
                Console.WriteLine("Товар не найден!");
            }
        }

        public Product FindByName (string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
