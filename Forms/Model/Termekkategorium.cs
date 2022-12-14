using System;
using System.Collections.Generic;

namespace Forms.Model;

public partial class Termekkategorium
{
    public int KatId { get; set; }

    public string KatNev { get; set; } = null!;

    public int? SzuloKat { get; set; }
}
