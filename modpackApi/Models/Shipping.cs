﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpackApi.Models;

public partial class Shipping
{
    public int ShippingId { get; set; }

    public string Description { get; set; }

    public decimal? DeliveryCost { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}