using System;
using System.Collections.Generic;

namespace Semana04_Web_EFCore.API.Data;

public partial class People
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public int? Dni { get; set; }
}
