﻿using System.Collections.Generic;

namespace restaurantApp.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual List<Item> Items { get; set; }
        public virtual decimal total
        {
            get
            {
                if (Items != null && Items.Count > 0)
                {
                    decimal totalPrice = 0;
                    foreach (Item item in Items)
                    {
                        totalPrice += item.Price;
                    }
                    return totalPrice;
                }
                return 0;
            }

        }
    }
}