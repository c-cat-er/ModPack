﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpack.Models;

public partial class AdministratorModification
{
    public int ModificationId { get; set; }

    public int AdministratorId { get; set; }

    public int ModifierId { get; set; }

    public string ModifierDescribe { get; set; }

    public DateTime ModificationTime { get; set; }

    public virtual Administrator Administrator { get; set; }

    public virtual Administrator Modifier { get; set; }
}