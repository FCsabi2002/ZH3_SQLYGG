using System;
using System.Collections.Generic;

namespace Forms.Model;

public partial class Rendele
{
    public int Sorszam { get; set; }

    public string? Login { get; set; }

    public DateTime? RendDatum { get; set; }

    public DateTime? SzallDatum { get; set; }

    public string? SzallCim { get; set; }

    public string? SzallMod { get; set; }

    public string? FizMod { get; set; }

    public string? SzamlaCim { get; set; }
}
