﻿using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.DTO
{
    public class ShoppingCartDto
    {
        public List<FoodItemInShoppingCart>? FoodItems { get; set; }
        public double TotalPrice { get; set; }
    }
}
