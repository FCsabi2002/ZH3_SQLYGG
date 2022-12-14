using System;
using System.Collections.Generic;

namespace Forms.Model;

public partial class RendelesTetel
{
    public int Sorszam { get; set; }

    public string Termekkod { get; set; } = null!;

    public double? Egysegar { get; set; }

    public double Mennyiseg { get; set; }
}
