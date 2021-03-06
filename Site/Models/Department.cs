﻿using System.Collections.Generic;
using System;
using System.Linq;

namespace Site.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //Um departamento tem varios vendedores

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime dataIni, DateTime dataFim)
        {
            return Sellers.Sum(seller => seller.TotalSales(dataIni, dataFim));
        }
    }
}
