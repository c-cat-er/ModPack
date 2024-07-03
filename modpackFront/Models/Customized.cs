﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpackFront.Models;

public partial class Customized
{
    public int CustomizedId { get; set; }

    public int MemberId { get; set; }

    public int PromotionId { get; set; }

    public string Name { get; set; }

    public string ImageFileName { get; set; }

    public decimal SalePrice { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<CustomizedSpecification> CustomizedSpecifications { get; set; } = new List<CustomizedSpecification>();

    public virtual ICollection<FavoriteItem> FavoriteItems { get; set; } = new List<FavoriteItem>();

    public virtual Member Member { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Promotion Promotion { get; set; }
}