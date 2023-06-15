﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper;

    public interface IProductRepository
    {
    public IEnumerable<Product> GetAllProducts();
    //public void UpdateProduct(int id, string newName, double newPrice);
    public Product GetProduct(int id);
    //public void UpdateProduct(Product product);



    }

