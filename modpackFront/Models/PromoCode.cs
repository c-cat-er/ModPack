﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpackFront.Models;

public partial class PromoCode
{
    public int PromoCodeId { get; set; }

    public string Code { get; set; }

    public string Method { get; set; }

    public string Description { get; set; }

    public string Limitation { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}