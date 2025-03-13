using System;
using System.Collections.Generic;

namespace KoperasiTentra.DAL.EF.Data;

public partial class user
{
    public long id { get; set; }

    public long ic_number { get; set; }

    public string customer_name { get; set; } = null!;

    public string monile_number { get; set; } = null!;

    public string email { get; set; } = null!;

    public string pin { get; set; } = null!;
}
