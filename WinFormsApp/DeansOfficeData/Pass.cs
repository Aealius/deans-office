using System;
using System.Collections.Generic;

namespace WinFormsApp.DeansOfficeData;

public partial class Pass
{
    public ushort Id { get; set; }

    public DateTime SkippedDate { get; set; }

    public string? Reason { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
