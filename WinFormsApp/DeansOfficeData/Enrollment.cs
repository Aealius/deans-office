using System;
using System.Collections.Generic;

namespace WinFormsApp.DeansOfficeData;

public partial class Enrollment
{
    public ushort Id { get; set; }

    public DateTime Edate { get; set; }

    public string? Reason { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
